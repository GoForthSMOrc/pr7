namespace Practica7
{
    partial class MainMenu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sculpt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Master = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hello = new System.Windows.Forms.Label();
            this.NewUser = new System.Windows.Forms.Button();
            this.ListButton = new System.Windows.Forms.Button();
            this.NewSculpture = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FindSculpt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Sculpt,
            this.Material,
            this.Size,
            this.Master});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 469);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Номер";
            // 
            // Sculpt
            // 
            this.Sculpt.Text = "Скульптура";
            this.Sculpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sculpt.Width = 84;
            // 
            // Material
            // 
            this.Material.Text = "Материал";
            this.Material.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Material.Width = 92;
            // 
            // Size
            // 
            this.Size.Text = "Размер";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Master
            // 
            this.Master.Text = "Мастер";
            this.Master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hello.Location = new System.Drawing.Point(179, 9);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(291, 40);
            this.Hello.TabIndex = 1;
            this.Hello.Text = "Добро пожаловать!";
            // 
            // NewUser
            // 
            this.NewUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUser.Location = new System.Drawing.Point(132, 52);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(360, 51);
            this.NewUser.TabIndex = 2;
            this.NewUser.Text = "Добавить нового пользователя";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // ListButton
            // 
            this.ListButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListButton.Location = new System.Drawing.Point(382, 159);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(243, 49);
            this.ListButton.TabIndex = 3;
            this.ListButton.Text = "Обновить список работ";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // NewSculpture
            // 
            this.NewSculpture.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewSculpture.Location = new System.Drawing.Point(382, 224);
            this.NewSculpture.Name = "NewSculpture";
            this.NewSculpture.Size = new System.Drawing.Size(243, 49);
            this.NewSculpture.TabIndex = 4;
            this.NewSculpture.Text = "Добавить новую запись";
            this.NewSculpture.UseVisualStyleBackColor = true;
            this.NewSculpture.Click += new System.EventHandler(this.NewSculpture_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(382, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(243, 49);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindSculpt
            // 
            this.FindSculpt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSculpt.Location = new System.Drawing.Point(382, 354);
            this.FindSculpt.Name = "FindSculpt";
            this.FindSculpt.Size = new System.Drawing.Size(243, 49);
            this.FindSculpt.TabIndex = 6;
            this.FindSculpt.Text = "Поиск записи";
            this.FindSculpt.UseVisualStyleBackColor = true;
            this.FindSculpt.Click += new System.EventHandler(this.FindSculpt_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 640);
            this.Controls.Add(this.FindSculpt);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewSculpture);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.listView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Sculpt;
        private System.Windows.Forms.ColumnHeader Material;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Master;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button NewSculpture;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button FindSculpt;
    }
}