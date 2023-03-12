using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class ToStringAlternate
    {
        public string ToAlternatingCases(string s)
        {
            var result = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    result.Append(char.ToUpper(c));
                }
                else if (char.IsUpper(c))
                {
                    result.Append(char.ToLower(c));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
