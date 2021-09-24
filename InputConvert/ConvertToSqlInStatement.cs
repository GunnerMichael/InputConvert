using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConvert
{
    public class ConvertToSqlInStatement
    {
        public string Convert(string[] input, bool quoted)
        {
            StringBuilder x = new StringBuilder();

            x.Append("IN (");


            for (int row = 0; row < input.Length; row++)
            {
                string line = input[row].Replace("\n", string.Empty).Replace("\r", string.Empty);


                if (quoted == true)
                {
                    x.AppendFormat("'{0}',", line.Trim());
                }
                else
                {
                    x.AppendFormat("{0},", line.Trim());
                }

            }

            x.Remove(x.Length - 1, 1);
            x.Append(")");

            return x.ToString();
        }
    }
}
