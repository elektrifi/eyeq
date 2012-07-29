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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retrieveProcBtn
            // 
            this.retrieveProcBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.retrieveProcBtn.Location = new System.Drawing.Point(26, 89);
            this.retrieveProcBtn.Name = "retrieveProcBtn";
            this.retrieveProcBtn.Size = new System.Drawing.Size(208, 39);
            this.retrieveProcBtn.TabIndex = 1;
            this.retrieveProcBtn.Text = "Retrieve Manual";
            this.retrieveProcBtn.Click += new System.EventHandler(this.retrieveProcBtn_Click);
            // 
            // eyeQLogo
            // 
            this.eyeQLogo.Image = ((System.Drawing.Image)(resources.GetObject("eyeQLogo.Image")));
            this.eyeQLogo.Location = new System.Drawing.Point(120, 17);
            this.eyeQLogo.Name = "eyeQLogo";
            this.eyeQLogo.Size = new System.Drawing.Size(275, 50);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.cancelBtn.Location = new System.Drawing.Point(26, 148);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(208, 39);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.statusLbl.ForeColor = System.Drawing.Color.Black;
            this.statusLbl.Location = new System.Drawing.Point(260, 89);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(215, 39);
            this.statusLbl.Text = "...";
            this.statusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statusLbl.Visible = false;
            // 
            // EyeQUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.eyeQLogo);
            this.Controls.Add(this.retrieveProcBtn);
            this.Name = "EyeQUserControl1";
            this.Size = new System.Drawing.Size(498, 218);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retrieveProcBtn;
        private System.Windows.Forms.PictureBox eyeQLogo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label statusLbl;
    }
}
