using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Human_resources
{
    public class HiredHelper
    {
        public static List<Group> IsEmployeeWorking(string deafultGroup)
        {
            return new List<Group>()
            {
                new Group() {IdGroup = 0, Name = deafultGroup},
                new Group{IdGroup = 1, Name = "Tak" },
                new Group { IdGroup = 2, Name = "Nie"}
            };
        }
    }
}
