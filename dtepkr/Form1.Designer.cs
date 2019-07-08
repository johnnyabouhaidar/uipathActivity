namespace dtepkr
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DoneBTN = new System.Windows.Forms.Button();
            this.dmy = new System.Windows.Forms.RadioButton();
            this.mdy = new System.Windows.Forms.RadioButton();
            this.dmyslash = new System.Windows.Forms.RadioButton();
            this.mdyslash = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DoneBTN
            // 
            this.DoneBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoneBTN.Location = new System.Drawing.Point(0, 294);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(349, 23);
            this.DoneBTN.TabIndex = 1;
            this.DoneBTN.Text = "Done";
            this.DoneBTN.UseVisualStyleBackColor = true;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // dmy
            // 
            this.dmy.AutoSize = true;
            this.dmy.Location = new System.Drawing.Point(29, 116);
            this.dmy.Name = "dmy";
            this.dmy.Size = new System.Drawing.Size(105, 21);
            this.dmy.TabIndex = 2;
            this.dmy.TabStop = true;
            this.dmy.Text = "dd-MM-yyyy";
            this.dmy.UseVisualStyleBackColor = true;
            this.dmy.CheckedChanged += new System.EventHandler(this.dmy_CheckedChanged);
            // 
            // mdy
            // 
            this.mdy.AutoSize = true;
            this.mdy.Location = new System.Drawing.Point(29, 143);
            this.mdy.Name = "mdy";
            this.mdy.Size = new System.Drawing.Size(105, 21);
            this.mdy.TabIndex = 3;
            this.mdy.TabStop = true;
            this.mdy.Text = "MM-dd-yyyy";
            this.mdy.UseVisualStyleBackColor = true;
            this.mdy.CheckedChanged += new System.EventHandler(this.mdy_CheckedChanged);
            // 
            // dmyslash
            // 
            this.dmyslash.AutoSize = true;
            this.dmyslash.Location = new System.Drawing.Point(29, 170);
            this.dmyslash.Name = "dmyslash";
            this.dmyslash.Size = new System.Drawing.Size(103, 21);
            this.dmyslash.TabIndex = 4;
            this.dmyslash.TabStop = true;
            this.dmyslash.Text = "dd/MM/yyyy";
            this.dmyslash.UseVisualStyleBackColor = true;
            this.dmyslash.CheckedChanged += new System.EventHandler(this.dmyslash_CheckedChanged);
            // 
            // mdyslash
            // 
            this.mdyslash.AutoSize = true;
            this.mdyslash.Location = new System.Drawing.Point(29, 197);
            this.mdyslash.Name = "mdyslash";
            this.mdyslash.Size = new System.Drawing.Size(103, 21);
            this.mdyslash.TabIndex = 5;
            this.mdyslash.TabStop = true;
            this.mdyslash.Text = "MM/dd/yyyy";
            this.mdyslash.UseVisualStyleBackColor = true;
            this.mdyslash.CheckedChanged += new System.EventHandler(this.mdyslash_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please Select Format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdyslash);
            this.Controls.Add(this.dmyslash);
            this.Controls.Add(this.mdy);
            this.Controls.Add(this.dmy);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Date Picker";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DoneBTN;
        private System.Windows.Forms.RadioButton dmy;
        private System.Windows.Forms.RadioButton mdy;
        private System.Windows.Forms.RadioButton dmyslash;
        private System.Windows.Forms.RadioButton mdyslash;
        private System.Windows.Forms.Label label1;

    }
}