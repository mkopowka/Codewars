using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveEveryOther
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> resultList = new List<object>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    resultList.Add(arr[i]);
                }
            }

            return resultList.ToArray();
        }
    }
}
