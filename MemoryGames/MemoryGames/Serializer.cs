using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace MemoryGames
{
    public class Serializer
    {
        public Serializer()
        {

        }

        public void SerializeObject(string filename, SerializeObject serializeObject)
        {
            try
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                using (Stream stream = File.Open(filename, FileMode.Create))
                {
                    bFormatter.Serialize(stream, serializeObject);
                }
            }
            catch (Exception)
            {
                GameBackground.CleanBackground();
                Console.SetCursorPosition(16, 10);
                Console.WriteLine("Error occured while trying to write  file ");
                Thread.Sleep(1000);
                GameBackground.CleanBackground();
                GameManager.Menu();
            }
        }

        public SerializeObject DeSerializeObject(string filename)
        {
            SerializeObject serializeObject;
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                serializeObject = (SerializeObject)bFormatter.Deserialize(stream);
            }
            return serializeObject;
        }
    }
}
