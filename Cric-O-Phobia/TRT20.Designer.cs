namespace Cric_O_Phobia
{
    partial class TRT20
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trT20TextBox = new System.Windows.Forms.TextBox();
            this.trT20NoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rankings";
            // 
            // trT20TextBox
            // 
            this.trT20TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trT20TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trT20TextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trT20TextBox.Location = new System.Drawing.Point(32, 66);
            this.trT20TextBox.Multiline = true;
            this.trT20TextBox.Name = "trT20TextBox";
            this.trT20TextBox.ReadOnly = true;
            this.trT20TextBox.Size = new System.Drawing.Size(135, 244);
            this.trT20TextBox.TabIndex = 3;
            // 
            // trT20NoTextBox
            // 
            this.trT20NoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.trT20NoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trT20NoTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trT20NoTextBox.Location = new System.Drawing.Point(213, 66);
            this.trT20NoTextBox.Multiline = true;
            this.trT20NoTextBox.Name = "trT20NoTextBox";
            this.trT20NoTextBox.ReadOnly = true;
            this.trT20NoTextBox.Size = new System.Drawing.Size(68, 244);
            this.trT20NoTextBox.TabIndex = 4;
            // 
            // TRT20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 359);
            this.Controls.Add(this.trT20NoTextBox);
            this.Controls.Add(this.trT20TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TRT20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRT20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trT20TextBox;
        private System.Windows.Forms.TextBox trT20NoTextBox;
    }
}