using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConvert
{
    public class ConvertToArray
    {
        public string Convert(string[] input)
        {

            StringBuilder x = new StringBuilder();

            x.Append("var x = new string[] {");

            for (int row = 0; row < input.Length; row++)
            {
                string line = input[row].Replace("\n", string.Empty).Replace("\r", string.Empty);

                string escaped = line.Replace("\"", "\\\"");

                x.AppendFormat("\"{0}\",", escaped);
            }

            x.Remove(x.Length - 1, 1);

            x.Append("};");

            return x.ToString();
        }
    }
}
