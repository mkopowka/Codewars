using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class RemoveUrlAnchors
    {
        public static string RemoveUrlAnchor(string url)
        {
            string[] parts = url.Split('#');
            return parts[0];
        }
    }
}
