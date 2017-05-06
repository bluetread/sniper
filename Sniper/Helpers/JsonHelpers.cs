using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

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

        public static T ConvertIgnoreName<T>(string data, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(nameof(data), data);
            Ensure.ArgumentNotNullOrEmptyString(nameof(name), name);

            var parsedData = JObject.Parse(data);
            //dynamic jsonExpando = new ExpandoObject();

            var filteredTokens = GetTokensExcept(parsedData, name);
            //var jsonObject = JObject.FromObject(jsonExpando);
            var jsonObject = JObject.FromObject(filteredTokens);
            var test = jsonObject.ToObject<T>();
            return jsonObject.ToObject<T>();


            //if (desiredData == null) return default(T);

            //var serializer = new JsonSerializer { MissingMemberHandling = MissingMemberHandling.Ignore };
            //try
            //{
            //    var test = desiredData.ToObject<T>(serializer);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            //return desiredData.ToObject<T>(serializer);
        }

        private static IList<JToken> GetTokensExcept(JToken element, string name)
        {
            var list = new List<JToken>();
            if (element == null) return list;
            var children = element.Children().ToList();
            if (children.Any())
            {
                foreach (var child in children)
                {
                    var subList = GetTokensExcept(child, name);
                    foreach (var item in subList)
                    {
                        if (!item.Path.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                        {
                            list.Add(item);
                        }
                    }
                }
            }
            else
            {
                if (!element.Path.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    list.Add(element);
                }
            }
            return list;
        }
    }
}