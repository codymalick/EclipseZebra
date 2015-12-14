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
        public List<DateTime> appointments;
        
        public Patient() {
            firstName = string.Empty;
            lastName = string.Empty;
            appointments = new List<DateTime>();
        }

        public IEnumerable<DateTime> nextThree() {
            return this.appointments.Take(3);
        }

        public void reset()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.appointments = new List<DateTime>();
        }
    }
}
