using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toStringBuilderCommand_Click(object sender, EventArgs e)
        {
            outputText.Text = new ConvertToStringBuilder().Convert(inputText.Lines);
        }

        private void toArrayCommand_Click(object sender, EventArgs e)
        {
            outputText.Text = new ConvertToArray().Convert(inputText.Lines);
        }
    }
}
