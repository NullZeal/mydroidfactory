using System.Runtime.Serialization.Formatters.Binary;
using MyDroidFactory.Business;

namespace MyDroidFactory.Data
{
    public static class DroidBinaryData
    {
        private static string GetFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Droids.bin");
        }

        public static List<Droid> Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Droid>();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var reader = new BinaryFormatter();
                return (List<Droid>)reader.Deserialize(stream);
            }
        }

        public static void Save(List<Droid> listOfDroids)
        {
            string filePath = GetFilePath();

            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                var writer = new BinaryFormatter();
                writer.Serialize(stream, listOfDroids);
                stream.Close();
            }
        }
    }
}
