using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Likes
    {
        public static string Likez(string[] name)
        {
            string like = " ";
            if (name.Length == 0)
            {
                like = "no one likes this";
            }
            for (int i = 0; i < name.Length; i++)
            {
               if(name.Length == 1)
                {
                    like = name[i]+" likes this";
                }else if(name.Length ==2)
                {
                    like = name[0] + " and "+name[1] + " " + "like this";
                }
                else if (name.Length == 3)
                {
                    like = name[0] + ", " + name[1] + " and " +name[2] + " like this";
                }
                else if (name.Length >= 4)
                {
                    like = name[0] + ", " + name[1] + " and " + (name.Length - 2).ToString() +" others like this";
                }

            }
            return like;
        }
    }
}
