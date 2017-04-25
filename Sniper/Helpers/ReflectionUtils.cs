using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using static Sniper.WarningsErrors.MessageSuppression;
// ReSharper disable AssignNullToNotNullAttribute
//This file was copied from SinpleJson (from Octokit) and modified for Sniper
namespace Sniper
{
    [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldBeSpelledCorrectly, MessageId = "Utils")]
    internal static class ReflectionUtils
    {
        private static readonly object[] _emptyObjects = { };

        [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldNotHaveIncorrectSuffix)]
        public delegate object GetDelegate(object source);
        [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldNotHaveIncorrectSuffix)]
        public delegate void SetDelegate(object source, object value);
        [SuppressMessage(Categories.Naming, MessageAttributes.IdentifiersShouldNotHaveIncorrectSuffix)]
        public delegate object ConstructorDelegate(params object[] args);

        public delegate TValue ThreadSafeDictionaryValueFactory<in TKey, out TValue>(TKey key);

        public static Type GetTypeInfo(Type type)
        {
            return type;
        }

        public static Attribute GetAttribute(MemberInfo info, Type type)
        {
            if (info == null || type == null || !Attribute.IsDefined(info, type))
                return null;
            return Attribute.GetCustomAttribute(info, type);
        }

        public static Type GetGenericListElementType(Type type)
        {
            IEnumerable<Type> interfaces = type.GetInterfaces();
            foreach (var implementedInterface in interfaces)
            {
                if (IsTypeGeneric(implementedInterface) &&
                    implementedInterface.GetGenericTypeDefinition() == typeof(IList<>))
                {
                    return GetGenericTypeArguments(implementedInterface)[0];
                }
            }
            return GetGenericTypeArguments(type)[0];
        }

        public static Attribute GetAttribute(Type objectType, Type attributeType)
        {
            if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
                return null;
            return Attribute.GetCustomAttribute(objectType, attributeType);
        }

        public static Type[] GetGenericTypeArguments(Type type)
        {
            return type.GetGenericArguments();
        }

        public static bool IsTypeGeneric(Type type)
        {
            return GetTypeInfo(type).IsGenericType;
        }

        public static bool IsTypeGenericeCollectionInterface(Type type)
        {
            if (!IsTypeGeneric(type))
                return false;

            var genericDefinition = type.GetGenericTypeDefinition();

            return (genericDefinition == typeof(IList<>)
                    || genericDefinition == typeof(ICollection<>)
                    || genericDefinition == typeof(IEnumerable<>)
            );
        }

        public static bool IsAssignableFrom(Type type1, Type type2)
        {
            return GetTypeInfo(type1).IsAssignableFrom(GetTypeInfo(type2));
        }

        public static bool IsTypeDictionary(Type type)
        {
            if (typeof(IDictionary).IsAssignableFrom(type))
                return true;
            if (!GetTypeInfo(type).IsGenericType)
                return false;

            var genericDefinition = type.GetGenericTypeDefinition();
            return genericDefinition == typeof(IDictionary<,>);
        }

        public static bool IsNullableType(Type type)
        {
            return GetTypeInfo(type).IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public static object ToNullableType(object obj, Type nullableType)
        {
            return obj == null ? null : Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture);
        }

        public static bool IsValueType(Type type)
        {
            return GetTypeInfo(type).IsValueType;
        }

        public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
        {
            return type.GetConstructors();
        }

        public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
        {
            var constructorInfos = GetConstructors(type);
            foreach (var constructorInfo in constructorInfos)
            {
                var parameters = constructorInfo.GetParameters();
                if (argsType.Length != parameters.Length)
                    continue;

                var i = 0;
                var matches = true;
                foreach (var parameterInfo in constructorInfo.GetParameters())
                {
                    if (parameterInfo.ParameterType != argsType[i])
                    {
                        matches = false;
                        break;
                    }
                }

                if (matches)
                    return constructorInfo;
            }

            return null;
        }

        public static IEnumerable<PropertyInfo> GetProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        }

        public static IEnumerable<FieldInfo> GetFields(Type type)
        {
            return type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        }

        public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetGetMethod(true);
        }

        public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
        {
            return propertyInfo.GetSetMethod(true);
        }

        public static ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
        {
            return GetConstructorByExpression(constructorInfo);
        }

        public static ConstructorDelegate GetContructor(Type type, params Type[] argsType)
        {
            return GetConstructorByExpression(type, argsType);
        }

        public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
        {
            return constructorInfo.Invoke;
        }

        public static ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
        {
            var constructorInfo = GetConstructorInfo(type, argsType);
            return constructorInfo == null ? null : GetConstructorByReflection(constructorInfo);
        }

        public static ConstructorDelegate GetConstructorByExpression(ConstructorInfo constructorInfo)
        {
            var paramsInfo = constructorInfo.GetParameters();
            var param = Expression.Parameter(typeof(object[]), "args");
            var argsExp = new Expression[paramsInfo.Length];
            for (var i = 0; i < paramsInfo.Length; i++)
            {
                Expression index = Expression.Constant(i);
                var paramType = paramsInfo[i].ParameterType;
                Expression paramAccessorExp = Expression.ArrayIndex(param, index);
                Expression paramCastExp = Expression.Convert(paramAccessorExp, paramType);
                argsExp[i] = paramCastExp;
            }
            var newExp = Expression.New(constructorInfo, argsExp);
            var lambda = Expression.Lambda<Func<object[], object>>(newExp, param);
            var compiledLambda = lambda.Compile();
            return args => compiledLambda(args);
        }

        public static ConstructorDelegate GetConstructorByExpression(Type type, params Type[] argsType)
        {
            var constructorInfo = GetConstructorInfo(type, argsType);
            return constructorInfo == null ? null : GetConstructorByExpression(constructorInfo);
        }

        public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
        {
            return GetGetMethodByExpression(propertyInfo);
        }

        public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
        {
            return GetGetMethodByExpression(fieldInfo);
        }

        public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
        {
            var methodInfo = GetGetterMethodInfo(propertyInfo);
            return source => methodInfo.Invoke(source, _emptyObjects);
        }

        public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
        {
            return fieldInfo.GetValue;
        }

        public static GetDelegate GetGetMethodByExpression(PropertyInfo propertyInfo)
        {
            var getMethodInfo = GetGetterMethodInfo(propertyInfo);
            var instance = Expression.Parameter(typeof(object), "instance");
            var instanceCast = (!IsValueType(propertyInfo.DeclaringType)) ? Expression.TypeAs(instance, propertyInfo.DeclaringType) : Expression.Convert(instance, propertyInfo.DeclaringType);
            var compiled = Expression.Lambda<Func<object, object>>(Expression.TypeAs(Expression.Call(instanceCast, getMethodInfo), typeof(object)), instance).Compile();
            return source => compiled(source);
        }

        public static GetDelegate GetGetMethodByExpression(FieldInfo fieldInfo)
        {
            var instance = Expression.Parameter(typeof(object), "instance");
            var member = Expression.Field(Expression.Convert(instance, fieldInfo.DeclaringType), fieldInfo);
            var compiled = Expression.Lambda<GetDelegate>(Expression.Convert(member, typeof(object)), instance).Compile();
            return source => compiled(source);
        }

        public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
        {
            return GetSetMethodByExpression(propertyInfo);
        }

        public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
        {
            return GetSetMethodByExpression(fieldInfo);
        }

        public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
        {
            var methodInfo = GetSetterMethodInfo(propertyInfo);
            return delegate (object source, object value) { methodInfo.Invoke(source, new[] { value }); };
        }

        public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
        {
            return fieldInfo.SetValue;
        }

        public static SetDelegate GetSetMethodByExpression(PropertyInfo propertyInfo)
        {
            var setMethodInfo = GetSetterMethodInfo(propertyInfo);
            var instance = Expression.Parameter(typeof(object), "instance");
            var value = Expression.Parameter(typeof(object), "value");
            var instanceCast = (!IsValueType(propertyInfo.DeclaringType)) ? Expression.TypeAs(instance, propertyInfo.DeclaringType) : Expression.Convert(instance, propertyInfo.DeclaringType);
            var valueCast = (!IsValueType(propertyInfo.PropertyType)) ? Expression.TypeAs(value, propertyInfo.PropertyType) : Expression.Convert(value, propertyInfo.PropertyType);
            var compiled = Expression.Lambda<Action<object, object>>(Expression.Call(instanceCast, setMethodInfo, valueCast), instance, value).Compile();
            return delegate (object source, object val) { compiled(source, val); };
        }

        public static SetDelegate GetSetMethodByExpression(FieldInfo fieldInfo)
        {
            var instance = Expression.Parameter(typeof(object), "instance");
            var value = Expression.Parameter(typeof(object), "value");
            var compiled = Expression.Lambda<Action<object, object>>(
                Assign(Expression.Field(Expression.Convert(instance, fieldInfo.DeclaringType), fieldInfo), Expression.Convert(value, fieldInfo.FieldType)), instance, value).Compile();
            return delegate (object source, object val) { compiled(source, val); };
        }

        public static BinaryExpression Assign(Expression left, Expression right)
        {
            var assign = typeof(Assigner<>).MakeGenericType(left.Type).GetMethod("Assign");
            var assignExpr = Expression.Add(left, right, assign);
            return assignExpr;
        }

        private static class Assigner<T>
        {
            public static T Assign(ref T left, T right)
            {
                return (left = right);
            }
        }

        public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>
        {
            private readonly object _lock = new object();
            private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;
            private Dictionary<TKey, TValue> _dictionary;

            public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
            {
                _valueFactory = valueFactory;
            }

            private TValue Get(TKey key)
            {
                if (_dictionary == null)
                    return AddValue(key);
                TValue value;
                if (!_dictionary.TryGetValue(key, out value))
                    return AddValue(key);
                return value;
            }

            private TValue AddValue(TKey key)
            {
                var value = _valueFactory(key);
                lock (_lock)
                {
                    if (_dictionary == null)
                    {
                        _dictionary = new Dictionary<TKey, TValue> { [key] = value };
                    }
                    else
                    {
                        TValue val;
                        if (_dictionary.TryGetValue(key, out val))
                            return val;
                        var dict = new Dictionary<TKey, TValue>(_dictionary)
                        {
                            [key] = value
                        };
                        _dictionary = dict;
                    }
                }
                return value;
            }

            public void Add(TKey key, TValue value)
            {
                throw new NotImplementedException();
            }

            public bool ContainsKey(TKey key)
            {
                return _dictionary.ContainsKey(key);
            }

            public ICollection<TKey> Keys => _dictionary.Keys;

            public bool Remove(TKey key)
            {
                throw new NotImplementedException();
            }

            public bool TryGetValue(TKey key, out TValue value)
            {
                value = this[key];
                return true;
            }

            public ICollection<TValue> Values => _dictionary.Values;

            public TValue this[TKey key]
            {
                get => Get(key);
                set => throw new NotImplementedException();
            }

            public void Add(KeyValuePair<TKey, TValue> item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(KeyValuePair<TKey, TValue> item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public int Count => _dictionary.Count;

            public bool IsReadOnly => throw new NotImplementedException();

            public bool Remove(KeyValuePair<TKey, TValue> item)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                return _dictionary.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return _dictionary.GetEnumerator();
            }
        }
    }
}

