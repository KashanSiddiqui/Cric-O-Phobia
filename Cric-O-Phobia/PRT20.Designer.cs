namespace Cric_O_Phobia
{
    partial class PRT20
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
            this.prT20Bowl = new System.Windows.Forms.TextBox();
            this.prT20Bat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(222, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prT20Bowl
            // 
            this.prT20Bowl.BackColor = System.Drawing.SystemColors.Control;
            this.prT20Bowl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prT20Bowl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prT20Bowl.Location = new System.Drawing.Point(197, 63);
            this.prT20Bowl.Multiline = true;
            this.prT20Bowl.Name = "prT20Bowl";
            this.prT20Bowl.ReadOnly = true;
            this.prT20Bowl.Size = new System.Drawing.Size(100, 215);
            this.prT20Bowl.TabIndex = 8;
            // 
            // prT20Bat
            // 
            this.prT20Bat.BackColor = System.Drawing.SystemColors.Control;
            this.prT20Bat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prT20Bat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prT20Bat.Location = new System.Drawing.Point(27, 63);
            this.prT20Bat.Multiline = true;
            this.prT20Bat.Name = "prT20Bat";
            this.prT20Bat.ReadOnly = true;
            this.prT20Bat.Size = new System.Drawing.Size(100, 215);
            this.prT20Bat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bowler";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Batsmen";
            // 
            // PRT20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 347);
            this.Controls.Add(this.prT20Bowl);
            this.Controls.Add(this.prT20Bat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PRT20";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRT20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prT20Bowl;
        private System.Windows.Forms.TextBox prT20Bat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}