namespace Cric_O_Phobia
{
    partial class TRTEST
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trTestNoTextBox = new System.Windows.Forms.TextBox();
            this.trTestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rankings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team";
            // 
            // trTestNoTextBox
            // 
            this.trTestNoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trTestNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trTestNoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trTestNoTextBox.Location = new System.Drawing.Point(240, 35);
            this.trTestNoTextBox.Multiline = true;
            this.trTestNoTextBox.Name = "trTestNoTextBox";
            this.trTestNoTextBox.ReadOnly = true;
            this.trTestNoTextBox.Size = new System.Drawing.Size(59, 274);
            this.trTestNoTextBox.TabIndex = 6;
            // 
            // trTestTextBox
            // 
            this.trTestTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trTestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trTestTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trTestTextBox.Location = new System.Drawing.Point(24, 35);
            this.trTestTextBox.Multiline = true;
            this.trTestTextBox.Name = "trTestTextBox";
            this.trTestTextBox.ReadOnly = true;
            this.trTestTextBox.Size = new System.Drawing.Size(100, 274);
            this.trTestTextBox.TabIndex = 5;
            // 
            // TRTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trTestNoTextBox);
            this.Controls.Add(this.trTestTextBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TRTEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRTEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trTestNoTextBox;
        private System.Windows.Forms.TextBox trTestTextBox;
    }
}