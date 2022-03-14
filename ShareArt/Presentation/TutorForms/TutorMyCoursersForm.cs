using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareArt.Visual
{
    public partial class TutorMyCoursersForm : Form
    {
        public TutorMyCoursersForm()
        {
            InitializeComponent();
        }

        private void TutorMyCoursersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
