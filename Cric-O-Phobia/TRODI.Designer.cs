namespace Cric_O_Phobia
{
    partial class TRODI
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
            this.button1 = new System.Windows.Forms.Button();
            this.trOdiTextBox = new System.Windows.Forms.TextBox();
            this.trOdiNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trOdiTextBox
            // 
            this.trOdiTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trOdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trOdiTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trOdiTextBox.Location = new System.Drawing.Point(38, 40);
            this.trOdiTextBox.Multiline = true;
            this.trOdiTextBox.Name = "trOdiTextBox";
            this.trOdiTextBox.ReadOnly = true;
            this.trOdiTextBox.Size = new System.Drawing.Size(138, 284);
            this.trOdiTextBox.TabIndex = 1;
            // 
            // trOdiNoTextBox
            // 
            this.trOdiNoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trOdiNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trOdiNoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trOdiNoTextBox.Location = new System.Drawing.Point(221, 47);
            this.trOdiNoTextBox.Multiline = true;
            this.trOdiNoTextBox.Name = "trOdiNoTextBox";
            this.trOdiNoTextBox.ReadOnly = true;
            this.trOdiNoTextBox.Size = new System.Drawing.Size(59, 277);
            this.trOdiNoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rankings";
            // 
            // TRODI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trOdiNoTextBox);
            this.Controls.Add(this.trOdiTextBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TRODI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRODI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox trOdiTextBox;
        private System.Windows.Forms.TextBox trOdiNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}