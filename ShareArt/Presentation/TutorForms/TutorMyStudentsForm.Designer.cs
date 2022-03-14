
namespace ShareArt.Visual
{
    partial class TutorMyStudentsForm
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
            this.btnSearchMyStudentsTutor = new System.Windows.Forms.Button();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 651);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSearchMyStudentsTutor
            // 
            this.btnSearchMyStudentsTutor.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMyStudentsTutor.Location = new System.Drawing.Point(785, 219);
            this.btnSearchMyStudentsTutor.Name = "btnSearchMyStudentsTutor";
            this.btnSearchMyStudentsTutor.Size = new System.Drawing.Size(143, 47);
            this.btnSearchMyStudentsTutor.TabIndex = 2;
            this.btnSearchMyStudentsTutor.Text = "SEARCH";
            this.btnSearchMyStudentsTutor.UseVisualStyleBackColor = true;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.txtBoxUsername.Location = new System.Drawing.Point(742, 147);
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(246, 56);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Location = new System.Drawing.Point(801, 324);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(107, 45);
            this.filter.TabIndex = 4;
            this.filter.Text = "filter";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(952, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "\t✘";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TutorMyStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.btnSearchMyStudentsTutor);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "TutorMyStudentsForm";
            this.Text = "TutorMyStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchMyStudentsTutor;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.Label btnExit;
    }
}