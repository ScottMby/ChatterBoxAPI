﻿namespace ChatterBox.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
        public Chat Chat { get; set; }
        public int ChatId { get; set; }
        public string contents { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
