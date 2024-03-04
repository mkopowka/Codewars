using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    /*
     * Input:

        a string strng
        an array of strings arr
        Output of function contain_all_rots(strng, arr) (or containAllRots or contain-all-rots):

        a boolean true if all rotations of strng are included in arr
        false otherwise
        Examples:
        contain_all_rots(
          "bsjq", ["bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs"]) -> true

        contain_all_rots(
          "Ajylvpy", ["Ajylvpy", "ylvpyAj", "jylvpyA", "lvpyAjy", "pyAjylv", "vpyAjyl", "ipywee"]) -> false)
        Note:
        Though not correct in a mathematical sense

        we will consider that there are no rotations of strng == ""
        and for any array arr: contain_all_rots("", arr) --> true
    */
    internal class ContainAllRotss
    {
        public static bool ContainAllRots(string strng, List<string> arr)
        {
            if (strng == "") return true;

            HashSet<string> rotations = GetAllRotations(strng);

            foreach (string rotation in rotations)
            {
                if (!arr.Contains(rotation))
                    return false;
            }

            return true;
        }

        private static HashSet<string> GetAllRotations(string str)
        {
            HashSet<string> rotations = new HashSet<string>();
            for (int i = 0; i < str.Length; i++)
            {
                string rotation = str.Substring(i) + str.Substring(0, i);
                rotations.Add(rotation);
            }
            return rotations;
        }
    }
}
