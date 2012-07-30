namespace eyeQWin32
{
    partial class eyeQMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startPanel = new System.Windows.Forms.Panel();
            this.eyeQUserControl11 = new eyeQ.EyeQUserControl1();
            this.eyeQUserControl21 = new eyeQ.EyeQUserControl2();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.eyeQUserControl21);
            this.startPanel.Controls.Add(this.eyeQUserControl11);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(624, 442);
            this.startPanel.TabIndex = 1;
            // 
            // eyeQUserControl11
            // 
            this.eyeQUserControl11.BackColor = System.Drawing.Color.White;
            this.eyeQUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eyeQUserControl11.Location = new System.Drawing.Point(0, 0);
            this.eyeQUserControl11.Name = "eyeQUserControl11";
            this.eyeQUserControl11.Size = new System.Drawing.Size(624, 442);
            this.eyeQUserControl11.TabIndex = 0;
            // 
            // eyeQUserControl21
            // 
            this.eyeQUserControl21.BackColor = System.Drawing.Color.White;
            this.eyeQUserControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eyeQUserControl21.Location = new System.Drawing.Point(0, 0);
            this.eyeQUserControl21.Name = "eyeQUserControl21";
            this.eyeQUserControl21.Size = new System.Drawing.Size(624, 442);
            this.eyeQUserControl21.TabIndex = 1;
            // 
            // eyeQMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.startPanel);
            this.Name = "eyeQMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "eyeQ Start";
            this.Load += new System.EventHandler(this.eyeQForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eyeQForm_FormClosing);
            this.startPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private eyeQ.EyeQUserControl1 eyeQUserControl11;
        private eyeQ.EyeQUserControl2 eyeQUserControl21;


    }
}

