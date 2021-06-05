using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputConvert
{
    public class ConvertToStringBuilder
    {
        public string Convert(string[] input)
        {
            StringBuilder output = new StringBuilder();


            for (int row = 0; row < input.Length; row++)
            {
                string line = input[row].Replace("\n", string.Empty).Replace("\r", string.Empty);

                string escaped = line.Replace("\"", "\\\"");
                output.AppendLine(String.Format("x.AppendLine(\"{0}\");", escaped));
            }

            return output.ToString();
        }
    }
}
