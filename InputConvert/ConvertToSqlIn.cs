using System;

namespace InputConvert
{
    internal class ConvertToSqlIn
    {
        public ConvertToSqlIn()
        {
        }

        internal string Convert(string[] lines, bool quoted)
        {
            string output = string.Empty;
            string quotemark = String.Empty;

            if (quoted)
            {
                 quotemark = "'";
            }

            if (lines.Length > 0)
            {
                output += "IN (";
                foreach(var line in lines)
                {

                    output += $"{quotemark}{line}{quotemark},";
                }

                output = $"{output.TrimEnd(',')})";
            }

            return output;
        }
    }
}