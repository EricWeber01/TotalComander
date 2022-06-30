using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalComander
{
    class Editer
    {
        // public string StrAfterEdit { get; set; } = string.Empty;
        public string EditString(string str)
        {
            if (str[str.Length - 1] == '\\')
            {
                str = str.Remove(str.Length - 1, 1);
                while (str[str.Length - 1] != '\\')
                {
                    str = str.Remove(str.Length - 1, 1);

                }
            }
            else if (str[str.Length - 1] != '\\')
            {
                while (str[str.Length - 1] != '\\')
                {
                    str = str.Remove(str.Length - 1, 1);
                }
            }
            return str;
        }
    }
}
