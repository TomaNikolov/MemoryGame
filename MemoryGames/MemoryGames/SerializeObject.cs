using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace MemoryGames
{ 
    [Serializable]
   public class SerializeObject
    {
        
        private GameEngine gameEngine;

        public GameEngine GameEngine
        {
            get { return this.gameEngine; }
            set { this.gameEngine = value; }
        }

        public SerializeObject()
        {
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("GameEngine", this.GameEngine);
          
        }
    }
}
