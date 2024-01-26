using Microsoft.EntityFrameworkCore;

namespace TrackerIoT.Models
{
    public class MessageContext : DbContext
    {
        public void Seed()
        {
            Families.Add(new Family { Name = "Doe", FamilyId = 1 });
            Users.Add(new User { FamilyId = 1, Id = 1, Name = "John", Type = UserType.Admin });
            Users.Add(new User { FamilyId = 1, Id = 2, Name = "Jenny", Type = UserType.Limited });
            
            // Make shure the id of the device is the same one set in the Arduino sketch for the AVR IoT.
            Devices.Add(new Device { FamilyId = 1, Type = DeviceType.Normal, Id = 8989989 });
        }

        public MessageContext()
        {
          // ef needs this constructor even though it is never called by 
         // my code in the application. EF needs it to set up the contexts

          // Failure to have it will result in a 
          //  No suitable constructor found for entity type 'Message'. exception
          Seed();
        }

        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {
            Seed();
        }

        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Family> Families { get; set; } = null!;
        public DbSet<Device> Devices { get; set; } = null!;
    }
}
