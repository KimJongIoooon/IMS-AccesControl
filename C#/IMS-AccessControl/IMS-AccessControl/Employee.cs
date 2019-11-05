using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_AccessControl
{
    class Employee
    {
        public string name;
        public string pasId; 
        public string StartHour;
        public string EndHour;

        public Employee(string name, string pasId, int startHour, int endHour)
        {
            this.name = name;
            this.pasId = pasId;
            StartHour = Convert.ToString(startHour);
            while (StartHour.Length<4)
            {
                StartHour = "0" + StartHour;

            }
            EndHour = Convert.ToString(endHour);
            while (EndHour.Length < 4)
            {
                EndHour = "0" + EndHour;
            }
            
        }

        public override string ToString()
        {
            return $"{pasId} {StartHour}-{EndHour}, {name}";

        }
    }
}
