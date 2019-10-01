using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _476_Number_Complement
    {
        public int FindComplement(int num)
        {

            var index = (int)(Math.Log(num, 2) + 1);

            var mask = (1 << index) - 1;
            return ~num & mask;
        }
    }
}
