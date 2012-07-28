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
            this.retrieveProcTextBox = new System.Windows.Forms.TextBox();
            this.retrieveProcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.retrieveProcLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retrieveProcTextBox
            // 
            this.retrieveProcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.retrieveProcTextBox.Location = new System.Drawing.Point(26, 56);
            this.retrieveProcTextBox.Name = "retrieveProcTextBox";
            this.retrieveProcTextBox.Size = new System.Drawing.Size(226, 23);
            this.retrieveProcTextBox.TabIndex = 0;
            this.retrieveProcTextBox.Text = " ...";
            this.retrieveProcTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // retrieveProcBtn
            // 
            this.retrieveProcBtn.Location = new System.Drawing.Point(26, 105);
            this.retrieveProcBtn.Name = "retrieveProcBtn";
            this.retrieveProcBtn.Size = new System.Drawing.Size(100, 20);
            this.retrieveProcBtn.TabIndex = 1;
            this.retrieveProcBtn.Text = "Retrieve";
            this.retrieveProcBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(152, 105);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 20);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // retrieveProcLbl
            // 
            this.retrieveProcLbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.retrieveProcLbl.Location = new System.Drawing.Point(26, 33);
            this.retrieveProcLbl.Name = "retrieveProcLbl";
            this.retrieveProcLbl.Size = new System.Drawing.Size(162, 20);
            this.retrieveProcLbl.Text = "Retrieve Procedure:";
            // 
            // EyeQUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.retrieveProcLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.retrieveProcBtn);
            this.Controls.Add(this.retrieveProcTextBox);
            this.Name = "EyeQUserControl1";
            this.Size = new System.Drawing.Size(284, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox retrieveProcTextBox;
        private System.Windows.Forms.Button retrieveProcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label retrieveProcLbl;
    }
}
