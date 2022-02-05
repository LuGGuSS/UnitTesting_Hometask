using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSum
{
    public class StringSum
    {
        public string Sum(string s1, string s2)
        {
            int i1 = int.Parse(s1);
            int i2 = int.Parse(s2);

            return (i1 + i2).ToString();
        }
    }
}
