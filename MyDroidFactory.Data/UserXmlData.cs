using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDroidFactory.Business;
using System.Xml.Serialization;

namespace MyDroidFactory.Data
{
    public static class UserXmlData
    {
        private static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + "user.xml";
        }

        public static List<User> GetUserList()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            string fileContent = File.ReadAllText(filePath);
            if (fileContent == "")
                return new List<User>();

            using (var reader = new StringReader(fileContent))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                return (List<User>)serializer.Deserialize(reader)!;
            }
        }

        public static void SaveUserList(List<User> list)
        {
            string filePath = GetFilePath();
            using (var writer = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(writer, list);
            }
        }
    }
}
