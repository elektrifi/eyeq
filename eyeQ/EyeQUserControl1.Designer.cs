namespace eyeQ
{
    partial class EyeQUserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EyeQUserControl1));
            this.retrieveProcBtn = new System.Windows.Forms.Button();
            this.eyeQLogo = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // retrieveProcBtn
            // 
            this.retrieveProcBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.retrieveProcBtn.Location = new System.Drawing.Point(26, 89);
            this.retrieveProcBtn.Name = "retrieveProcBtn";
            this.retrieveProcBtn.Size = new System.Drawing.Size(275, 39);
            this.retrieveProcBtn.TabIndex = 1;
            this.retrieveProcBtn.Text = "Retrieve Manual";
            this.retrieveProcBtn.Click += new System.EventHandler(this.retrieveProcBtn_Click);
            // 
            // eyeQLogo
            // 
            this.eyeQLogo.Image = ((System.Drawing.Image)(resources.GetObject("eyeQLogo.Image")));
            this.eyeQLogo.Location = new System.Drawing.Point(26, 13);
            this.eyeQLogo.Name = "eyeQLogo";
            this.eyeQLogo.Size = new System.Drawing.Size(275, 50);
            // 
            // EyeQUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eyeQLogo);
            this.Controls.Add(this.retrieveProcBtn);
            this.Name = "EyeQUserControl1";
            this.Size = new System.Drawing.Size(331, 218);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retrieveProcBtn;
        private System.Windows.Forms.PictureBox eyeQLogo;
    }
}
