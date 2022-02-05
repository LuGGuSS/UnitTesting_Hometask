using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public class StringSum
    {
        public string Sum(string s1, string s2)
        {
            var i1 = s1.Any(ch => !char.IsDigit(ch)) ? 0 : int.Parse(s1);
            var i2 = s2.Any(ch => !char.IsDigit(ch)) ? 0 : int.Parse(s2);

            return (i1 + i2).ToString();
        }
    }
}
