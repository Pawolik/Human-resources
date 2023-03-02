using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Human_resources
{
    public class FileHelper<T> where T : new()
    {
        private string _file;

        public FileHelper(string file)
        {
            _file = file;
        }

        public void SerializeToFile(T employees)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var streamWriter = new StreamWriter(_file))
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }

        public T DeserialazeFromFile()
        {
            if (!File.Exists(_file))
            {
                return new T();
            }

            var serializer = new XmlSerializer(typeof(T));
            using (var streamReader = new StreamReader(_file))
            {
                var employees = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return employees;
            }
        }
    }
}

