namespace eyeQWin32
{
    partial class eyeQForm
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
            this.eyeQUserControl11 = new eyeQ.EyeQUserControl1();
            this.SuspendLayout();
            // 
            // eyeQUserControl11
            // 
            this.eyeQUserControl11.BackColor = System.Drawing.Color.White;
            this.eyeQUserControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eyeQUserControl11.Location = new System.Drawing.Point(0, 0);
            this.eyeQUserControl11.Name = "eyeQUserControl11";
            this.eyeQUserControl11.Size = new System.Drawing.Size(332, 219);
            this.eyeQUserControl11.TabIndex = 0;
            // 
            // eyeQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 219);
            this.Controls.Add(this.eyeQUserControl11);
            this.Name = "eyeQForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "eyeQ Win32 Form";
            this.Load += new System.EventHandler(this.eyeQForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eyeQForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private eyeQ.EyeQUserControl1 eyeQUserControl11;

    }
}

