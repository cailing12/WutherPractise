using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wuther.SignalR
{
    public class CountService
    {
        private int _count = 0;

        public int GetLatestCount()
        {
            return _count++;
        }
    }
}
