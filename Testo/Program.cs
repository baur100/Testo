using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EntiryStaffEntities();
            var person = new Staff()
            {
                DateOfBirth = new DateTime(1975, 12, 20),
                FirstName = "Ivan",
                LastName = "Petrov",
                Id = 2,
                Position = "Manager"
            };
            context.Staffs.Add(person);
            context.SaveChanges();
        }
    }
}
