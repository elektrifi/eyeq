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
    public partial class eyeQMainForm : Form
    {
        public eyeQMainForm()
        {
            InitializeComponent();

            startPanel.Controls.Clear();
            startPanel.Visible = true;
            eyeQUserControl11.Show();
            eyeQUserControl21.Hide();
            startPanel.Controls.Add(eyeQUserControl11);
            startPanel.Controls.Add(eyeQUserControl21);           

            this.CenterToScreen();
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
            // Connect to services
            eyeQUserControl11.InitializeServices((int)Handle);
            //eyeQUserControl21.InitializeServices((int)Handle);
        }
        
        //public void eyeQForm_Start(object sender, EventArgs e)
        //{
            //startPanel.Controls.Clear();
            //startPanel.Visible = true;
            //eyeQUserControl21.Hide();
            //eyeQUserControl11.Show();
            //startPanel.Controls.Add(eyeQUserControl11);
        //}

        ////////////////////////////////////////////////////////
        //
        // On Close Event
        // When the form is closed exit gracefully
        //
        ////////////////////////////////////////////////////////
        private void eyeQForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Disconnect from services
            eyeQUserControl11.CloseServices();
            //eyeQUserControl21.CloseServices();
        }
     }
}
