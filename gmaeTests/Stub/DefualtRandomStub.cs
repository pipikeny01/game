using gmae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmae.Tests
{
    public class DefualtRandomStub : IRandom
    {
        public int Next(int min, int max)
        {
            return 20;
        }
    }
}
