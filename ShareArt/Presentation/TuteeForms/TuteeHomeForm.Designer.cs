
namespace ShareArt.Visual
{
    partial class TuteeHomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMyCourserTutee = new System.Windows.Forms.Button();
            this.btnNewCoursersTutee = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Tutee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(349, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "Let\'s explore \r\nthe world of art";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMyCourserTutee
            // 
            this.btnMyCourserTutee.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCourserTutee.Location = new System.Drawing.Point(154, 263);
            this.btnMyCourserTutee.Name = "btnMyCourserTutee";
            this.btnMyCourserTutee.Size = new System.Drawing.Size(692, 165);
            this.btnMyCourserTutee.TabIndex = 2;
            this.btnMyCourserTutee.Text = "MY COURSERS";
            this.btnMyCourserTutee.UseVisualStyleBackColor = true;
            // 
            // btnNewCoursersTutee
            // 
            this.btnNewCoursersTutee.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCoursersTutee.Location = new System.Drawing.Point(154, 454);
            this.btnNewCoursersTutee.Name = "btnNewCoursersTutee";
            this.btnNewCoursersTutee.Size = new System.Drawing.Size(692, 158);
            this.btnNewCoursersTutee.TabIndex = 3;
            this.btnNewCoursersTutee.Text = "NEW COURSERS";
            this.btnNewCoursersTutee.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(954, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "\t✘";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TuteeHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(46F, 90F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewCoursersTutee);
            this.Controls.Add(this.btnMyCourserTutee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
            this.Name = "TuteeHomeForm";
            this.Text = "TuteeHomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMyCourserTutee;
        private System.Windows.Forms.Button btnNewCoursersTutee;
        private System.Windows.Forms.Label btnExit;
    }
}