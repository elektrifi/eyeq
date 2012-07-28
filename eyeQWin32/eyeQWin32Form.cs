using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eyeQ;

namespace eyeQWin32
{
    public partial class eyeQForm : Form
    {
        public eyeQForm()
        {
            InitializeComponent();
        }

       ////////////////////////////////////////////////////////
        //
        // On Load Event
        // When the form is loaded then we can initialize the 
        // main control. The main control needs the window
        // handle of this top level window in order to correctly
        // work with the Service Manager
        //
        ////////////////////////////////////////////////////////
        private void eyeQForm_Load(object sender, EventArgs e)
        {
            eyeQUserControl11.InitializeServices((int)Handle);
        }

        ////////////////////////////////////////////////////////
        //
        // On Close Event
        // When the form is closed exit gracefullu
        //
        ////////////////////////////////////////////////////////
        private void eyeQForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            eyeQUserControl11.CloseServices();
        }
    }
}
