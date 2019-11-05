using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_AccessControl
{
    class Card
    {
        public string name;
        public string pasId; 
        public int StartHour;
        public int EndHour;

        public Card(string name, string pasId, int startHour, int endHour)
        {
            this.name = name;
            this.pasId = pasId;
            StartHour = startHour;
            EndHour = endHour;
        }

        public override string ToString()
        {
            return $"{pasId} {StartHour}-{EndHour}, {name}";

        }
    }
}
