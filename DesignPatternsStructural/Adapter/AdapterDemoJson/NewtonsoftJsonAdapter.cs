using DesignPatternsStructural.Adapter.Service;
using Newtonsoft.Json;

namespace DesignPatternsStructural.Adapter.AdapterDemoJson
{
    public class NewtonsoftJsonAdapter : IJsonConvertTest
    {
        public T Deserializer<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json)!;
        }

        public string Serializer(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
