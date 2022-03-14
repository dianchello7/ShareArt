
namespace ShareArt.Visual
{
    partial class TutorHomeForm
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
            this.btnMyCoursersTutor = new System.Windows.Forms.Button();
            this.btnMyStudentsTutor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Tutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(258, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "we really appreciate your\r\ninvestment in society";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMyCoursersTutor
            // 
            this.btnMyCoursersTutor.Location = new System.Drawing.Point(135, 270);
            this.btnMyCoursersTutor.Name = "btnMyCoursersTutor";
            this.btnMyCoursersTutor.Size = new System.Drawing.Size(694, 163);
            this.btnMyCoursersTutor.TabIndex = 2;
            this.btnMyCoursersTutor.Text = "MY COURSERS";
            this.btnMyCoursersTutor.UseVisualStyleBackColor = true;
            // 
            // btnMyStudentsTutor
            // 
            this.btnMyStudentsTutor.Location = new System.Drawing.Point(135, 453);
            this.btnMyStudentsTutor.Name = "btnMyStudentsTutor";
            this.btnMyStudentsTutor.Size = new System.Drawing.Size(694, 171);
            this.btnMyStudentsTutor.TabIndex = 3;
            this.btnMyStudentsTutor.Text = "MY STUDENTS";
            this.btnMyStudentsTutor.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(953, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "\t✘";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TutorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMyStudentsTutor);
            this.Controls.Add(this.btnMyCoursersTutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TutorHomeForm";
            this.Text = "TutorHomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMyCoursersTutor;
        private System.Windows.Forms.Button btnMyStudentsTutor;
        private System.Windows.Forms.Label btnExit;
    }
}