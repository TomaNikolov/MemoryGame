using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemoryGames
{
   public class Serializer
    {
        public Serializer()
        {

        }

        public void SerializeObject(string filename, SerializeObject serializeObject)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, serializeObject);
            stream.Close();
        }

        public SerializeObject DeSerializeObject(string filename)
        {
            SerializeObject serializeObject;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            serializeObject = (SerializeObject)bFormatter.Deserialize(stream);
            stream.Close();
            return serializeObject;
        }
    }
}
