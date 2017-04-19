using Sniper.Reflection;
using System;
using System.Reflection;
using static Sniper.Application.Messages.MessageKeys;

namespace Sniper
{
    internal class PropertyOrField
    {
        private readonly PropertyInfo _propertyInfo;
        private readonly FieldInfo _fieldInfo;

        public PropertyOrField(PropertyInfo propertyInfo) : this((MemberInfo)propertyInfo)
        {
            _propertyInfo = propertyInfo;

            CanRead = propertyInfo.CanRead;
            CanWrite = propertyInfo.CanWrite;
            IsStatic = ReflectionUtils.GetGetterMethodInfo(propertyInfo).IsStatic;
            IsPublic = ReflectionUtils.GetGetterMethodInfo(propertyInfo).IsPublic;
        }

        public PropertyOrField(FieldInfo fieldInfo) : this((MemberInfo)fieldInfo)
        {
            _fieldInfo = fieldInfo;

            CanRead = true;
            CanWrite = true;
            IsStatic = fieldInfo.IsStatic;
            IsPublic = fieldInfo.IsPublic;
        }

        protected PropertyOrField(MemberInfo memberInfo)
        {
            MemberInfo = memberInfo;
            Base64Encoded = memberInfo.GetCustomAttribute<SerializeAsBase64Attribute>() != null;
            SerializeNull = memberInfo.GetCustomAttribute<SerializeNullAttribute>() != null;
            HasParameterAttribute = memberInfo.GetCustomAttribute<ParameterAttribute>() != null;
        }

        public bool CanRead { get; }

        public bool CanWrite { get; }

        public bool Base64Encoded { get; }

        public bool SerializeNull { get; }

        public bool IsStatic { get; }

        public bool IsPublic { get; }

        public bool HasParameterAttribute { get; }

        public MemberInfo MemberInfo { get; }

        public object GetValue(object instance)
        {
            if (_propertyInfo != null)
                return _propertyInfo.GetValue(instance);
            if (_fieldInfo != null)
                return _fieldInfo.GetValue(instance);
            throw new InvalidOperationException(FieldAndPropertyBothNull);
        }

        public void SetValue(object instance, object value)
        {
            if (_propertyInfo != null)
            {
                _propertyInfo.SetValue(instance, value);
                return;
            }
            if (_fieldInfo != null)
            {
                _fieldInfo.SetValue(instance, value);
                return;
            }
            throw new InvalidOperationException(FieldAndPropertyBothNull);
        }

        public string JsonFieldName => MemberInfo.GetJsonFieldName();

        public ReflectionUtils.GetDelegate GetDelegate
        {
            get
            {
                ReflectionUtils.GetDelegate getDelegate = null;
                if (_propertyInfo != null)
                {
                    getDelegate = ReflectionUtils.GetGetMethod(_propertyInfo);
                }
                if (_fieldInfo != null)
                {
                    getDelegate = ReflectionUtils.GetGetMethod(_fieldInfo);
                }


                if (getDelegate == null)
                {
                    throw new InvalidOperationException(FieldAndPropertyBothNull);
                }

                if (Base64Encoded)
                {
                    return delegate (object source)
                    {
                        var value = getDelegate(source);
                        var stringValue = value as string;
                        return stringValue == null ? value : stringValue.ToBase64String();
                    };
                }

                return getDelegate;
            }
        }
        public ReflectionUtils.SetDelegate SetDelegate
        {
            get
            {
                ReflectionUtils.SetDelegate setDelegate = null;
                if (_propertyInfo != null)
                {
                    setDelegate = ReflectionUtils.GetSetMethod(_propertyInfo);
                }
                if (_fieldInfo != null)
                {
                    setDelegate = ReflectionUtils.GetSetMethod(_fieldInfo);
                }
                if (setDelegate == null)
                {
                    throw new InvalidOperationException(FieldAndPropertyBothNull);
                }
                if (Base64Encoded)
                {
                    return delegate (object source, object value)
                    {
                        var stringValue = value as string;
                        if (stringValue == null)
                        {
                            setDelegate(source, value);
                        }
                        setDelegate(source, stringValue.FromBase64String());
                    };
                }
                return setDelegate;
            }
        }

        public Type Type
        {
            get
            {
                if (_propertyInfo != null)
                {
                    return _propertyInfo.PropertyType;
                }
                if (_fieldInfo != null)
                {
                    return _fieldInfo.FieldType;
                }
                throw new InvalidOperationException(FieldAndPropertyBothNull);
            }
        }

        public bool CanDeserialize => (IsPublic || HasParameterAttribute)
                                      && !IsStatic
                                      && CanWrite
                                      && (_fieldInfo == null || !_fieldInfo.IsInitOnly);

        public bool CanSerialize => IsPublic && CanRead && !IsStatic;
    }
}
