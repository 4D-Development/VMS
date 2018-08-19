using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMS.Models
{
    public class FakeVolunteerRepository : IVolunteerRepository
    {
        public IEnumerable<Volunteer> Volunteers => new List<Volunteer> {
             new Volunteer { FirstName = "Sam" },
             new Volunteer { FirstName = "John" },
             new Volunteer { FirstName = "Grant" }
             };
    }
}
