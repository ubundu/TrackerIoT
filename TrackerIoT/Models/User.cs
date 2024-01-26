using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TrackerIoT.Models
{
    public enum UserType
    {
        Normal = 0,
        Admin = 1,
        Limited = 2
    }

    public class User
    {
        [Key]
        public long Id { get; set; }
        public UserType Type { get; set; }
        public long FamilyId { get; set; }
        public string? Name { get; set; }
    }
}
