using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace eyeQ
{
    public partial class EyeQUserControl1 : UserControl
    {
        Boolean textBoxFirstUse;

        public EyeQUserControl1()
        {
            InitializeComponent();
            textBoxFirstUse = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Clear textBox on first use
            if (textBoxFirstUse) {
                retrieveProcTextBox.Text = "";
                textBoxFirstUse = false;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            retrieveProcTextBox.Text = "";
        }
    }
}