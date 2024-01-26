using System.ComponentModel.DataAnnotations;

namespace TrackerIoT.Models
{
    public enum DeviceType
    {
        Normal = 0,
        Admin = 1
    }
    public class Device
    {
        [Key]
        public long Id { get; set; }
        public DeviceType Type { get; set; }
        public long FamilyId { get; set; }
    }
}
