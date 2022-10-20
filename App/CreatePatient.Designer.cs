namespace App
{
    partial class CreatePatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPesel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dodaj pacjenta";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.textAdress);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textPhoneNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textPesel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textLastName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textFirstName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 432);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(42, 36);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(180, 20);
            this.textFirstName.TabIndex = 1;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(42, 79);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(180, 20);
            this.textLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(42, 122);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(180, 20);
            this.textEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // textPesel
            // 
            this.textPesel.Location = new System.Drawing.Point(42, 165);
            this.textPesel.Name = "textPesel";
            this.textPesel.Size = new System.Drawing.Size(180, 20);
            this.textPesel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PESEL";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(42, 208);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.textPhoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefon";
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(42, 251);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(180, 20);
            this.textAdress.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Adres";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(42, 367);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 40);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Dodaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // CreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePatient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPesel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
    }
}