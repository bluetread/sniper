using Newtonsoft.Json;
using System;

namespace Sniper
{
    public static class JsonHelpers
    {
        internal class ConcreteConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType) => true;

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                // existingValue could be null, do not check
                Ensure.ArgumentNotNull(nameof(objectType), objectType);
                Ensure.ArgumentNotNull(nameof(reader), reader);
                Ensure.ArgumentNotNull(nameof(serializer), serializer);

                return serializer.Deserialize<T>(reader);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                // value could be null, do not check
                Ensure.ArgumentNotNull(nameof(serializer), serializer);
                Ensure.ArgumentNotNull(nameof(writer), writer);

                serializer.Serialize(writer, value);
            }
        }
    }
}