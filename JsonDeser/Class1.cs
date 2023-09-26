using Newtonsoft.Json;

namespace JsonDeser
{
    public class Class1
    {
        public static T Deserealize<T>()
        {
            string json = File.ReadAllText("C:\\Users\\kliker\\Desktop\\File.json");
            T list = JsonConvert.DeserializeObject<T>(json);
            return list;
        }
        public static void Serial<T>(T list)
        {
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText("C:\\Users\\kliker\\Desktop\\File.json", json);

        }

    }
}