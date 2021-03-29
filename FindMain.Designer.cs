namespace Practica7
{
    partial class FindMain
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
            this.FindNumberbutton = new System.Windows.Forms.Button();
            this.FindSculptButton = new System.Windows.Forms.Button();
            this.FindMaterialButton = new System.Windows.Forms.Button();
            this.FindSizeButton = new System.Windows.Forms.Button();
            this.FindMasterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindNumberbutton
            // 
            this.FindNumberbutton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindNumberbutton.Location = new System.Drawing.Point(152, 120);
            this.FindNumberbutton.Name = "FindNumberbutton";
            this.FindNumberbutton.Size = new System.Drawing.Size(174, 57);
            this.FindNumberbutton.TabIndex = 0;
            this.FindNumberbutton.Text = "По номеру";
            this.FindNumberbutton.UseVisualStyleBackColor = true;
            this.FindNumberbutton.Click += new System.EventHandler(this.FindNumberbutton_Click);
            // 
            // FindSculptButton
            // 
            this.FindSculptButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSculptButton.Location = new System.Drawing.Point(82, 183);
            this.FindSculptButton.Name = "FindSculptButton";
            this.FindSculptButton.Size = new System.Drawing.Size(316, 57);
            this.FindSculptButton.TabIndex = 1;
            this.FindSculptButton.Text = "По названию скульптуры";
            this.FindSculptButton.UseVisualStyleBackColor = true;
            this.FindSculptButton.Click += new System.EventHandler(this.FindSculptButton_Click);
            // 
            // FindMaterialButton
            // 
            this.FindMaterialButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindMaterialButton.Location = new System.Drawing.Point(152, 246);
            this.FindMaterialButton.Name = "FindMaterialButton";
            this.FindMaterialButton.Size = new System.Drawing.Size(174, 57);
            this.FindMaterialButton.TabIndex = 2;
            this.FindMaterialButton.Text = "По материалу";
            this.FindMaterialButton.UseVisualStyleBackColor = true;
            this.FindMaterialButton.Click += new System.EventHandler(this.FindMaterialButton_Click);
            // 
            // FindSizeButton
            // 
            this.FindSizeButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindSizeButton.Location = new System.Drawing.Point(152, 309);
            this.FindSizeButton.Name = "FindSizeButton";
            this.FindSizeButton.Size = new System.Drawing.Size(174, 57);
            this.FindSizeButton.TabIndex = 3;
            this.FindSizeButton.Text = "По размеру";
            this.FindSizeButton.UseVisualStyleBackColor = true;
            this.FindSizeButton.Click += new System.EventHandler(this.FindSizeButton_Click);
            // 
            // FindMasterButton
            // 
            this.FindMasterButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindMasterButton.Location = new System.Drawing.Point(152, 372);
            this.FindMasterButton.Name = "FindMasterButton";
            this.FindMasterButton.Size = new System.Drawing.Size(174, 57);
            this.FindMasterButton.TabIndex = 4;
            this.FindMasterButton.Text = "По мастеру";
            this.FindMasterButton.UseVisualStyleBackColor = true;
            this.FindMasterButton.Click += new System.EventHandler(this.FindMasterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Варианты поиска";
            // 
            // FindMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindMasterButton);
            this.Controls.Add(this.FindSizeButton);
            this.Controls.Add(this.FindMaterialButton);
            this.Controls.Add(this.FindSculptButton);
            this.Controls.Add(this.FindNumberbutton);
            this.Name = "FindMain";
            this.Text = "FindMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindNumberbutton;
        private System.Windows.Forms.Button FindSculptButton;
        private System.Windows.Forms.Button FindMaterialButton;
        private System.Windows.Forms.Button FindSizeButton;
        private System.Windows.Forms.Button FindMasterButton;
        private System.Windows.Forms.Label label1;
    }
}