using System.ComponentModel.DataAnnotations;

namespace TrackerIoT.Models
{
    public enum MessageType
    {
        Normal = 0,
        Conversation = 1,
        Config = 2
    }

    public class Message
    {
        [Key]
        public long Id { get; set; }
        public MessageType Type { get; set; }
        public long FamilyId { get; set; }
        public string? Content { get; set; }
    }
}
