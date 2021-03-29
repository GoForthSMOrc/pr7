namespace Practica7
{
    partial class DeleteOne
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
            this.DeleteNumber = new System.Windows.Forms.TextBox();
            this.DeleteHi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteNumber
            // 
            this.DeleteNumber.Location = new System.Drawing.Point(43, 88);
            this.DeleteNumber.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.DeleteNumber.Multiline = true;
            this.DeleteNumber.Name = "DeleteNumber";
            this.DeleteNumber.Size = new System.Drawing.Size(55, 38);
            this.DeleteNumber.TabIndex = 0;
            // 
            // DeleteHi
            // 
            this.DeleteHi.AutoSize = true;
            this.DeleteHi.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteHi.Location = new System.Drawing.Point(83, 9);
            this.DeleteHi.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.DeleteHi.Name = "DeleteHi";
            this.DeleteHi.Size = new System.Drawing.Size(242, 40);
            this.DeleteHi.TabIndex = 1;
            this.DeleteHi.Text = "Удалить запись";
            this.DeleteHi.Click += new System.EventHandler(this.DeleteHi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите номер записи";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(115, 173);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(156, 75);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 276);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteHi);
            this.Controls.Add(this.DeleteNumber);
            this.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "DeleteOne";
            this.Text = "DeleteOne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DeleteNumber;
        private System.Windows.Forms.Label DeleteHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
    }
}