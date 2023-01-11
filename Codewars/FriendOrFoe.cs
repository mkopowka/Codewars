using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class FriendOrFoe
    {
        public IEnumerable<string> FriendOrFoes(string[] names)
        {

            List<string> friends = names.Where(name => name.Length==4).ToList();

            return friends;
        }
    }
}
