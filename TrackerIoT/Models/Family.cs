using System.ComponentModel.DataAnnotations;

namespace TrackerIoT.Models
{
    public class Family
    {
        [Key]
        public long FamilyId { get; set; }
        public string Name { get; set; }
    }
}
