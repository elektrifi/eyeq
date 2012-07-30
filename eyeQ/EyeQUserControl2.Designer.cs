namespace eyeQ
{
    partial class EyeQUserControl2
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
            this.f2TxtBox = new System.Windows.Forms.TextBox();
            this.f2SendTextBtn = new System.Windows.Forms.Button();
            this.f2GoBackBtn = new System.Windows.Forms.Button();
            this.f2ClearTextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f2TxtBox
            // 
            this.f2TxtBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2TxtBox.Location = new System.Drawing.Point(20, 16);
            this.f2TxtBox.Multiline = true;
            this.f2TxtBox.Name = "f2TxtBox";
            this.f2TxtBox.Size = new System.Drawing.Size(760, 140);
            this.f2TxtBox.TabIndex = 0;
            this.f2TxtBox.Text = "Testing";
            // 
            // f2SendTextBtn
            // 
            this.f2SendTextBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2SendTextBtn.Location = new System.Drawing.Point(238, 176);
            this.f2SendTextBtn.Name = "f2SendTextBtn";
            this.f2SendTextBtn.Size = new System.Drawing.Size(96, 36);
            this.f2SendTextBtn.TabIndex = 1;
            this.f2SendTextBtn.Text = "Send Text";
            // 
            // f2GoBackBtn
            // 
            this.f2GoBackBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2GoBackBtn.Location = new System.Drawing.Point(488, 176);
            this.f2GoBackBtn.Name = "f2GoBackBtn";
            this.f2GoBackBtn.Size = new System.Drawing.Size(96, 36);
            this.f2GoBackBtn.TabIndex = 2;
            this.f2GoBackBtn.Text = "Go Back";
            // 
            // f2ClearTextBtn
            // 
            this.f2ClearTextBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2ClearTextBtn.Location = new System.Drawing.Point(357, 176);
            this.f2ClearTextBtn.Name = "f2ClearTextBtn";
            this.f2ClearTextBtn.Size = new System.Drawing.Size(109, 36);
            this.f2ClearTextBtn.TabIndex = 3;
            this.f2ClearTextBtn.Text = "Clear Text";
            // 
            // EyeQUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.f2ClearTextBtn);
            this.Controls.Add(this.f2GoBackBtn);
            this.Controls.Add(this.f2SendTextBtn);
            this.Controls.Add(this.f2TxtBox);
            this.Name = "EyeQUserControl2";
            this.Size = new System.Drawing.Size(800, 580);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox f2TxtBox;
        private System.Windows.Forms.Button f2SendTextBtn;
        private System.Windows.Forms.Button f2GoBackBtn;
        private System.Windows.Forms.Button f2ClearTextBtn;
    }
}
