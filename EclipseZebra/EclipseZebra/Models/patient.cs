using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EclipseZebra.Model
{
    public class Patient
    {
        public string firstName;
        public string lastName;
        public IEnumerable<DateTime> appointments;
        
        Patient() { }

        public IEnumerable<DateTime> nextThree() {
            return this.appointments.Take(3);
        }

    }
}
