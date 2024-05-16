namespace baze_booking
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signOut = new System.Windows.Forms.Button();
            this.passwordPanel1Lbl = new System.Windows.Forms.Label();
            this.mailPanel1Lbl = new System.Windows.Forms.Label();
            this.userIcon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Navy;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(788, 12);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(100, 60);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "Prijava";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signOut);
            this.panel1.Controls.Add(this.passwordPanel1Lbl);
            this.panel1.Controls.Add(this.mailPanel1Lbl);
            this.panel1.Location = new System.Drawing.Point(605, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 137);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // signOut
            // 
            this.signOut.Location = new System.Drawing.Point(88, 86);
            this.signOut.Name = "signOut";
            this.signOut.Size = new System.Drawing.Size(109, 37);
            this.signOut.TabIndex = 2;
            this.signOut.Text = "Odjavi se";
            this.signOut.UseVisualStyleBackColor = true;
            this.signOut.Click += new System.EventHandler(this.signOut_Click);
            // 
            // passwordPanel1Lbl
            // 
            this.passwordPanel1Lbl.AutoSize = true;
            this.passwordPanel1Lbl.Location = new System.Drawing.Point(7, 48);
            this.passwordPanel1Lbl.Name = "passwordPanel1Lbl";
            this.passwordPanel1Lbl.Size = new System.Drawing.Size(68, 20);
            this.passwordPanel1Lbl.TabIndex = 1;
            this.passwordPanel1Lbl.Text = "Lozinka:";
            // 
            // mailPanel1Lbl
            // 
            this.mailPanel1Lbl.AutoSize = true;
            this.mailPanel1Lbl.Location = new System.Drawing.Point(7, 12);
            this.mailPanel1Lbl.Name = "mailPanel1Lbl";
            this.mailPanel1Lbl.Size = new System.Drawing.Size(57, 20);
            this.mailPanel1Lbl.TabIndex = 0;
            this.mailPanel1Lbl.Text = "E-mail:";
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.Transparent;
            this.userIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIcon.BackgroundImage")));
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userIcon.Location = new System.Drawing.Point(828, 12);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(60, 60);
            this.userIcon.TabIndex = 5;
            this.userIcon.Visible = false;
            this.userIcon.Click += new System.EventHandler(this.userIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signOut;
        private System.Windows.Forms.Label passwordPanel1Lbl;
        private System.Windows.Forms.Label mailPanel1Lbl;
        private System.Windows.Forms.Panel userIcon;
    }
}

