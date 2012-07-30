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
            this.f2DeliverMessageBtn = new System.Windows.Forms.Button();
            this.f2GoBackBtn = new System.Windows.Forms.Button();
            this.f2ClearTextBtn = new System.Windows.Forms.Button();
            this.AdresseeComboBox = new System.Windows.Forms.ComboBox();
            this.f2ToBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f2TxtBox
            // 
            this.f2TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.f2TxtBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2TxtBox.Location = new System.Drawing.Point(20, 16);
            this.f2TxtBox.Multiline = true;
            this.f2TxtBox.Name = "f2TxtBox";
            this.f2TxtBox.Size = new System.Drawing.Size(760, 140);
            this.f2TxtBox.TabIndex = 0;
            this.f2TxtBox.Text = "Testing";
            // 
            // f2DeliverMessageBtn
            // 
            this.f2DeliverMessageBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2DeliverMessageBtn.Location = new System.Drawing.Point(104, 278);
            this.f2DeliverMessageBtn.Name = "f2DeliverMessageBtn";
            this.f2DeliverMessageBtn.Size = new System.Drawing.Size(143, 36);
            this.f2DeliverMessageBtn.TabIndex = 1;
            this.f2DeliverMessageBtn.Text = "Deliver Message";
            this.f2DeliverMessageBtn.Click += new System.EventHandler(this.f2SendTextBtn_Click);
            // 
            // f2GoBackBtn
            // 
            this.f2GoBackBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2GoBackBtn.Location = new System.Drawing.Point(500, 278);
            this.f2GoBackBtn.Name = "f2GoBackBtn";
            this.f2GoBackBtn.Size = new System.Drawing.Size(143, 36);
            this.f2GoBackBtn.TabIndex = 2;
            this.f2GoBackBtn.Text = "Go Back";
            // 
            // f2ClearTextBtn
            // 
            this.f2ClearTextBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2ClearTextBtn.Location = new System.Drawing.Point(294, 278);
            this.f2ClearTextBtn.Name = "f2ClearTextBtn";
            this.f2ClearTextBtn.Size = new System.Drawing.Size(156, 36);
            this.f2ClearTextBtn.TabIndex = 3;
            this.f2ClearTextBtn.Text = "Clear Text";
            // 
            // AdresseeComboBox
            // 
            this.AdresseeComboBox.DisplayMember = "Bryan Eldridge";
            this.AdresseeComboBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.AdresseeComboBox.Items.Add("Bryan Eldridge");
            this.AdresseeComboBox.Items.Add("Wayne Gafford");
            this.AdresseeComboBox.Items.Add("Leslie Eldridge");
            this.AdresseeComboBox.Items.Add("Jonathan Forbes");
            this.AdresseeComboBox.Location = new System.Drawing.Point(124, 208);
            this.AdresseeComboBox.Name = "AdresseeComboBox";
            this.AdresseeComboBox.Size = new System.Drawing.Size(656, 29);
            this.AdresseeComboBox.TabIndex = 4;
            // 
            // f2ToBtn
            // 
            this.f2ToBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.f2ToBtn.Location = new System.Drawing.Point(20, 208);
            this.f2ToBtn.Name = "f2ToBtn";
            this.f2ToBtn.Size = new System.Drawing.Size(98, 29);
            this.f2ToBtn.TabIndex = 5;
            this.f2ToBtn.Text = "Send To";
            // 
            // EyeQUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.f2ToBtn);
            this.Controls.Add(this.AdresseeComboBox);
            this.Controls.Add(this.f2ClearTextBtn);
            this.Controls.Add(this.f2GoBackBtn);
            this.Controls.Add(this.f2DeliverMessageBtn);
            this.Controls.Add(this.f2TxtBox);
            this.Name = "EyeQUserControl2";
            this.Size = new System.Drawing.Size(800, 580);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox f2TxtBox;
        private System.Windows.Forms.Button f2DeliverMessageBtn;
        private System.Windows.Forms.Button f2GoBackBtn;
        private System.Windows.Forms.Button f2ClearTextBtn;
        private System.Windows.Forms.ComboBox AdresseeComboBox;
        private System.Windows.Forms.Button f2ToBtn;
    }
}
