namespace Cric_O_Phobia
{
    partial class PRTEST
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
            this.prTestBowl = new System.Windows.Forms.TextBox();
            this.prTestBat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prTestBowl
            // 
            this.prTestBowl.BackColor = System.Drawing.SystemColors.Control;
            this.prTestBowl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prTestBowl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prTestBowl.Location = new System.Drawing.Point(206, 78);
            this.prTestBowl.Multiline = true;
            this.prTestBowl.Name = "prTestBowl";
            this.prTestBowl.ReadOnly = true;
            this.prTestBowl.Size = new System.Drawing.Size(119, 234);
            this.prTestBowl.TabIndex = 12;
            // 
            // prTestBat
            // 
            this.prTestBat.BackColor = System.Drawing.SystemColors.Control;
            this.prTestBat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prTestBat.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prTestBat.Location = new System.Drawing.Point(27, 63);
            this.prTestBat.Multiline = true;
            this.prTestBat.Name = "prTestBat";
            this.prTestBat.ReadOnly = true;
            this.prTestBat.Size = new System.Drawing.Size(139, 249);
            this.prTestBat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bowler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Batsmen";
            // 
            // PRTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 380);
            this.Controls.Add(this.prTestBowl);
            this.Controls.Add(this.prTestBat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PRTEST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRTEST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prTestBowl;
        private System.Windows.Forms.TextBox prTestBat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}