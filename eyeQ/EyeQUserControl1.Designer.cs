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
            this.retrieveProcTextBox = new System.Windows.Forms.TextBox();
            this.retrieveProcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.retrieveProcLbl = new System.Windows.Forms.Label();
            this.eyeQLogo = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // retrieveProcTextBox
            // 
            this.retrieveProcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.retrieveProcTextBox.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.retrieveProcTextBox.Location = new System.Drawing.Point(26, 111);
            this.retrieveProcTextBox.Name = "retrieveProcTextBox";
            this.retrieveProcTextBox.Size = new System.Drawing.Size(275, 29);
            this.retrieveProcTextBox.TabIndex = 0;
            // 
            // retrieveProcBtn
            // 
            this.retrieveProcBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.retrieveProcBtn.Location = new System.Drawing.Point(26, 156);
            this.retrieveProcBtn.Name = "retrieveProcBtn";
            this.retrieveProcBtn.Size = new System.Drawing.Size(100, 39);
            this.retrieveProcBtn.TabIndex = 1;
            this.retrieveProcBtn.Text = "Retrieve";
            this.retrieveProcBtn.Click += new System.EventHandler(this.retrieveProcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.clearBtn.Location = new System.Drawing.Point(201, 156);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 39);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // retrieveProcLbl
            // 
            this.retrieveProcLbl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.retrieveProcLbl.Location = new System.Drawing.Point(26, 78);
            this.retrieveProcLbl.Name = "retrieveProcLbl";
            this.retrieveProcLbl.Size = new System.Drawing.Size(180, 26);
            this.retrieveProcLbl.Text = "Retrieve Procedure:";
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
            this.Controls.Add(this.retrieveProcLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.retrieveProcBtn);
            this.Controls.Add(this.retrieveProcTextBox);
            this.Name = "EyeQUserControl1";
            this.Size = new System.Drawing.Size(331, 218);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox retrieveProcTextBox;
        private System.Windows.Forms.Button retrieveProcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label retrieveProcLbl;
        private System.Windows.Forms.PictureBox eyeQLogo;
    }
}
