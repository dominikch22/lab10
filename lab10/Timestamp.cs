using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Timestamp
    {
        public long startMillseconds;
        public long endMilliseocnds;

        public bool isBetween(int timeMilliseconds) {
            if (timeMilliseconds <= endMilliseocnds && timeMilliseconds >= startMillseconds) {
                return true;
            }
            return false;
        }
    }
}
