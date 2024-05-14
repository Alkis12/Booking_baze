namespace baze_booking
{
    partial class LogIn
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
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.forgottenPasswordLink = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.registerLink = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.forgottenPasswordLink);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.passwordTextBox);
            this.panel.Controls.Add(this.mailTextBox);
            this.panel.Controls.Add(this.registerLink);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(40, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 500);
            this.panel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgottenPasswordLink
            // 
            this.forgottenPasswordLink.AutoSize = true;
            this.forgottenPasswordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgottenPasswordLink.ForeColor = System.Drawing.Color.Navy;
            this.forgottenPasswordLink.Location = new System.Drawing.Point(5, 255);
            this.forgottenPasswordLink.Name = "forgottenPasswordLink";
            this.forgottenPasswordLink.Size = new System.Drawing.Size(164, 20);
            this.forgottenPasswordLink.TabIndex = 5;
            this.forgottenPasswordLink.Text = "Zaboravili ste lozinku?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(5, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lozinka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email adresa";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(9, 212);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(380, 30);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "\r\n";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextBox.Location = new System.Drawing.Point(9, 123);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(380, 30);
            this.mailTextBox.TabIndex = 0;
            this.mailTextBox.Text = "\r\n";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLink.ForeColor = System.Drawing.Color.Navy;
            this.registerLink.Location = new System.Drawing.Point(188, 52);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(177, 20);
            this.registerLink.TabIndex = 2;
            this.registerLink.Text = "Registujte se brzo i lako";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nemate Booking nalog?\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaš Booking nalog";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.panel);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prijava";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label registerLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label forgottenPasswordLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
    }
}