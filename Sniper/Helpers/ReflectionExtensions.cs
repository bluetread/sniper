using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace Sniper
{
    internal static class ReflectionExtensions
    {
        public static IEnumerable<PropertyInfo> GetAllProperties(this Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        }

        public static string GetJsonFieldName(this MemberInfo memberInfo)
        {
            var memberName = memberInfo.Name;
            var paramAttr = memberInfo.GetCustomAttribute<ParameterAttribute>();

            if (!string.IsNullOrEmpty(paramAttr?.Key))
            {
                memberName = paramAttr.Key;
            }

            return memberName.ToRubyCase();
        }

        public static IEnumerable<PropertyOrField> GetPropertiesAndFields(this Type type)
        {
            return ReflectionUtils.GetProperties(type).Select(property => new PropertyOrField(property))
                .Union(ReflectionUtils.GetFields(type).Select(field => new PropertyOrField(field)))
                .Where(p => (p.IsPublic || p.HasParameterAttribute) && !p.IsStatic);
        }

        public static IEnumerable<PropertyInfo> PropertiesWithAttribute<T>(this Type type) where T : Attribute
        {
            return type.GetProperties().Where(λ => Attribute.IsDefined(λ, typeof(T)));
        }

#if TooSpecificMethod
        public static IEnumerable<PropertyInfo> PropertiesWithAttributeEnabled<T>(this Type type) where T : Attribute
        {
            var propertyInfos = type.PropertiesWithAttribute<T>().ToList();
            foreach (var propertyInfo in propertyInfos)
            {
                var customAttributes = propertyInfo.CustomAttributes;
                foreach (var customAttributeData in customAttributes)
                {
                    var xxx = customAttributeData.AttributeType.GetPropertiesAndFields();
                }
            }
            return propertyInfos;
        }
#endif
        //TODO: break up into smaller methods doing individual tasks
        public static IDictionary<string, ICollection<string>> PropertyNamesWithAttribute<T>(
            this Type type, string filterByPropertyName = null, object filteredPropertyValue = null, bool ignoreMissingProperty = true) where T : Attribute
        {
            var props = type.PropertiesWithAttribute<T>().ToList();

            var filteredProps = new List<PropertyInfo>();
            if (string.IsNullOrWhiteSpace(filterByPropertyName))
            {
                filteredProps = props;
            }
            else
            {
                foreach (var propertyInfo in props)
                {
                    var value = propertyInfo.GetCustomAttributeNamedArgumentValueByName(filterByPropertyName);
                    if (ignoreMissingProperty)
                    {
                        if (value == null)
                        {
                            filteredProps.Add(propertyInfo);
                        }
                    }
                    else
                    {
                        if (value != filteredPropertyValue)
                        {
                            filteredProps.Add(propertyInfo);
                        }
                    }
                }
            }

            var list = new Dictionary<string, ICollection<string>>();
            foreach (var propertyInfo in filteredProps)
            {
                var name = propertyInfo.Name;
                var subList = new Collection<string>();
                var attrs = propertyInfo.CustomAttributes.Where(λ => λ.AttributeType == typeof(T)).ToList();
                var constructorArgs = attrs.Select(λ => λ.ConstructorArguments).ToList();
                foreach (var argList in constructorArgs)
                {
                    foreach (var argument in argList)
                    {
                        var itemList = (ReadOnlyCollection<CustomAttributeTypedArgument>)argument.Value;
                        if (itemList.Count > 0)
                        {
                            foreach (var item in itemList)
                            {
                                subList.Add((string)item.Value);
                            }
                        }
                    }
                }
                list.Add(name, subList);
            }
            return list;
        }

        //TODO: Revisit. Might be simpler. .GetProperty(item)?.GetValue(propertyValue, null)
        public static IReadOnlyCollection<CustomAttributeNamedArgument> GetCustomAttributeNamedArguments(this PropertyInfo propertyInfo)
        {
            var results = propertyInfo.CustomAttributes.Select(λ => λ.NamedArguments).ToList();
            var resultList = new List<CustomAttributeNamedArgument>();
            foreach (var result in results)
            {
                resultList.AddRange(result);
            }
            return new ReadOnlyCollection<CustomAttributeNamedArgument>(resultList);
        }

        public static object GetCustomAttributeNamedArgumentValueByName(this PropertyInfo propertyInfo, string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            var result = propertyInfo.GetCustomAttributeNamedArguments()
                .FirstOrDefault(λ => λ.MemberName.Equals(name, StringComparison.CurrentCultureIgnoreCase));

            return result.TypedValue.Value;
        }

        public static ICollection<CustomAttributeNamedArgument> GetCustomAttributesByNameFiltered<T>(
            this PropertyInfo propertyInfo, string name, object value = null, bool ignoreMissingProperty = true) where T : Attribute
        {
            var result = new Collection<CustomAttributeNamedArgument>();
            var namedArgList = propertyInfo.CustomAttributes.Select(λ => λ.NamedArguments).ToList();

            foreach (var argList in namedArgList)
            {
                foreach (var arg in argList)
                {
                    if (arg.MemberName.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (value == null)
                        {
                            result.Add(arg);
                        }
                        else
                        {
                            if (arg.TypedValue.Value.Equals(value))
                            {
                                result.Add(arg);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static bool IsDateTimeOffset(this Type type)
        {
            return type == typeof(DateTimeOffset) || type == typeof(DateTimeOffset?);
        }

        public static bool IsEnumeration(this Type type)
        {
            return type.IsEnum;
        }

        public static bool IsNullable(this Type type)
        {
            return type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public static Type GetTypeInfo(this Type type)
        {
            return type;
        }
    }
}