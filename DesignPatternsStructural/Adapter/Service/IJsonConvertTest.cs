namespace DesignPatternsStructural.Adapter.Service
{
    public interface IJsonConvertTest
    {
        string Serializer(object obj);
        T Deserializer<T>(string json);
    }
}
