using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmae
{
    public interface IRandom
    {
        int Next(int min, int max);
    }
}
