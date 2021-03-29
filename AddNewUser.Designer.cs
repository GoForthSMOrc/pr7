namespace Practica7
{
    partial class AddNewUser
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
            this.RefreshPassButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.LOG = new System.Windows.Forms.Label();
            this.PAS = new System.Windows.Forms.Label();
            this.NewLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.HelloNewUser = new System.Windows.Forms.Label();
            this.LittleHelp1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefreshPassButton
            // 
            this.RefreshPassButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshPassButton.Location = new System.Drawing.Point(75, 314);
            this.RefreshPassButton.Name = "RefreshPassButton";
            this.RefreshPassButton.Size = new System.Drawing.Size(121, 49);
            this.RefreshPassButton.TabIndex = 0;
            this.RefreshPassButton.Text = "Обновить";
            this.RefreshPassButton.UseVisualStyleBackColor = true;
            this.RefreshPassButton.Click += new System.EventHandler(this.RefreshPassButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(286, 314);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 49);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LOG
            // 
            this.LOG.AutoSize = true;
            this.LOG.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOG.Location = new System.Drawing.Point(68, 169);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(86, 40);
            this.LOG.TabIndex = 2;
            this.LOG.Text = "Login";
            // 
            // PAS
            // 
            this.PAS.AutoSize = true;
            this.PAS.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PAS.Location = new System.Drawing.Point(12, 209);
            this.PAS.Name = "PAS";
            this.PAS.Size = new System.Drawing.Size(142, 40);
            this.PAS.TabIndex = 3;
            this.PAS.Text = "Password";
            // 
            // NewLogin
            // 
            this.NewLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewLogin.Location = new System.Drawing.Point(167, 169);
            this.NewLogin.Multiline = true;
            this.NewLogin.Name = "NewLogin";
            this.NewLogin.Size = new System.Drawing.Size(251, 40);
            this.NewLogin.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(160, 209);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(151, 40);
            this.Password.TabIndex = 5;
            this.Password.Text = "Обновите";
            // 
            // HelloNewUser
            // 
            this.HelloNewUser.AutoSize = true;
            this.HelloNewUser.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloNewUser.Location = new System.Drawing.Point(26, 20);
            this.HelloNewUser.Name = "HelloNewUser";
            this.HelloNewUser.Size = new System.Drawing.Size(381, 35);
            this.HelloNewUser.TabIndex = 6;
            this.HelloNewUser.Text = "Добавить нового пользователя";
            this.HelloNewUser.Click += new System.EventHandler(this.HelloNewUser_Click);
            // 
            // LittleHelp1
            // 
            this.LittleHelp1.AutoSize = true;
            this.LittleHelp1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LittleHelp1.Location = new System.Drawing.Point(40, 123);
            this.LittleHelp1.Name = "LittleHelp1";
            this.LittleHelp1.Size = new System.Drawing.Size(367, 23);
            this.LittleHelp1.TabIndex = 7;
            this.LittleHelp1.Text = "*Логин должен быть не более 10 символов*";
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.LittleHelp1);
            this.Controls.Add(this.HelloNewUser);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NewLogin);
            this.Controls.Add(this.PAS);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RefreshPassButton);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshPassButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LOG;
        private System.Windows.Forms.Label PAS;
        private System.Windows.Forms.TextBox NewLogin;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label HelloNewUser;
        private System.Windows.Forms.Label LittleHelp1;
    }
}