namespace eyeQWinCE
{
    partial class eyeQStartFormCE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.eyeQUserControl11 = new eyeQ.EyeQUserControl1();
            this.eyeQUserControl21 = new eyeQ.EyeQUserControl2();
            this.SuspendLayout();
            // 
            // eyeQUserControl11
            // 
            this.eyeQUserControl11.Location = new System.Drawing.Point(0, 0);
            this.eyeQUserControl11.Name = "eyeQUserControl11";
            this.eyeQUserControl11.Size = new System.Drawing.Size(320, 371);
            this.eyeQUserControl11.TabIndex = 0;
            // 
            // eyeQUserControl21
            // 
            this.eyeQUserControl21.Location = new System.Drawing.Point(333, 0);
            this.eyeQUserControl21.Name = "eyeQUserControl21";
            this.eyeQUserControl21.Size = new System.Drawing.Size(305, 371);
            this.eyeQUserControl21.TabIndex = 1;
            // 
            // eyeQStartFormCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.eyeQUserControl21);
            this.Controls.Add(this.eyeQUserControl11);
            this.Menu = this.mainMenu1;
            this.Name = "eyeQStartFormCE";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private eyeQ.EyeQUserControl1 eyeQUserControl11;
        private eyeQ.EyeQUserControl2 eyeQUserControl21;
    }
}

