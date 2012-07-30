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
            this.deliverMessageBtn = new System.Windows.Forms.Button();
            this.messageGoBackBtn = new System.Windows.Forms.Button();
            this.clearMessageBtn = new System.Windows.Forms.Button();
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
            this.f2TxtBox.Size = new System.Drawing.Size(741, 140);
            this.f2TxtBox.TabIndex = 0;
            this.f2TxtBox.Text = "Testing";
            // 
            // deliverMessageBtn
            // 
            this.deliverMessageBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.deliverMessageBtn.Location = new System.Drawing.Point(104, 278);
            this.deliverMessageBtn.Name = "deliverMessageBtn";
            this.deliverMessageBtn.Size = new System.Drawing.Size(174, 36);
            this.deliverMessageBtn.TabIndex = 1;
            this.deliverMessageBtn.Text = "Deliver Message";
            // 
            // messageGoBackBtn
            // 
            this.messageGoBackBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.messageGoBackBtn.Location = new System.Drawing.Point(500, 278);
            this.messageGoBackBtn.Name = "messageGoBackBtn";
            this.messageGoBackBtn.Size = new System.Drawing.Size(174, 36);
            this.messageGoBackBtn.TabIndex = 2;
            this.messageGoBackBtn.Text = "Go Back";
            // 
            // clearMessageBtn
            // 
            this.clearMessageBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.clearMessageBtn.Location = new System.Drawing.Point(294, 278);
            this.clearMessageBtn.Name = "clearMessageBtn";
            this.clearMessageBtn.Size = new System.Drawing.Size(187, 36);
            this.clearMessageBtn.TabIndex = 3;
            this.clearMessageBtn.Text = "Clear Message";
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
            this.AdresseeComboBox.Size = new System.Drawing.Size(637, 29);
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
            this.Controls.Add(this.clearMessageBtn);
            this.Controls.Add(this.messageGoBackBtn);
            this.Controls.Add(this.deliverMessageBtn);
            this.Controls.Add(this.f2TxtBox);
            this.Name = "EyeQUserControl2";
            this.Size = new System.Drawing.Size(781, 560);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox f2TxtBox;
        private System.Windows.Forms.Button deliverMessageBtn;
        private System.Windows.Forms.Button messageGoBackBtn;
        private System.Windows.Forms.Button clearMessageBtn;
        private System.Windows.Forms.ComboBox AdresseeComboBox;
        private System.Windows.Forms.Button f2ToBtn;
    }
}
