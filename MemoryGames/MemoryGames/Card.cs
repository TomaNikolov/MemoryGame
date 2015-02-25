using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace MemoryGames
{
    [Serializable]
    public abstract class Card
    {
        public bool IsVisible { get; set; }

        public Card()
        {
            
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
        }

        public abstract void DrowSelf(int positionX, int positionY);
    }
}
