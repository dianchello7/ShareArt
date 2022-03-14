
namespace ShareArt.Visual
{
    partial class TutorMyCoursersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddCourseTutor = new System.Windows.Forms.Button();
            this.btnEditCourseTutor = new System.Windows.Forms.Button();
            this.btnDeleteCourseTutor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(669, 653);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddCourseTutor
            // 
            this.btnAddCourseTutor.Location = new System.Drawing.Point(721, 170);
            this.btnAddCourseTutor.Name = "btnAddCourseTutor";
            this.btnAddCourseTutor.Size = new System.Drawing.Size(242, 76);
            this.btnAddCourseTutor.TabIndex = 1;
            this.btnAddCourseTutor.Text = "ADD";
            this.btnAddCourseTutor.UseVisualStyleBackColor = true;
            // 
            // btnEditCourseTutor
            // 
            this.btnEditCourseTutor.Location = new System.Drawing.Point(721, 305);
            this.btnEditCourseTutor.Name = "btnEditCourseTutor";
            this.btnEditCourseTutor.Size = new System.Drawing.Size(242, 76);
            this.btnEditCourseTutor.TabIndex = 2;
            this.btnEditCourseTutor.Text = "EDIT";
            this.btnEditCourseTutor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourseTutor
            // 
            this.btnDeleteCourseTutor.Location = new System.Drawing.Point(721, 431);
            this.btnDeleteCourseTutor.Name = "btnDeleteCourseTutor";
            this.btnDeleteCourseTutor.Size = new System.Drawing.Size(242, 76);
            this.btnDeleteCourseTutor.TabIndex = 3;
            this.btnDeleteCourseTutor.Text = "DELETE";
            this.btnDeleteCourseTutor.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(952, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "\t✘";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TutorMyCoursersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteCourseTutor);
            this.Controls.Add(this.btnEditCourseTutor);
            this.Controls.Add(this.btnAddCourseTutor);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TutorMyCoursersForm";
            this.Text = "TutorMyCoursersForm";
            this.Load += new System.EventHandler(this.TutorMyCoursersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddCourseTutor;
        private System.Windows.Forms.Button btnEditCourseTutor;
        private System.Windows.Forms.Button btnDeleteCourseTutor;
        private System.Windows.Forms.Label btnExit;
    }
}