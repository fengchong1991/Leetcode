using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _448__Find_All_Numbers_Disappeared_in_an_Array
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {

            var disappeared = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {

                while (nums[i] != i + 1)
                {

                    if (nums[i] == nums[nums[i] - 1])
                    {
                        break;
                    }

                    var temp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = temp;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {

                if (nums[i] != i + 1)
                {
                    disappeared.Add(i + 1);
                }
            }

            return disappeared;
        }
    }
}
