using System;

namespace PetSupport.Core.Entities
{
    public class MessageText
    {
        public MessageText()
        {
            SendData = DateTime.Now;
        }
        
        public DateTime SendData { get; private set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }
    }
}