using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadast_leoduda
{
    public partial class Form2 : Form
    {
        Professor professor;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            professor = new Professor(txtnomeprof.Text, (Convert.ToInt32(txtidadeprof.Text)), txttitprof.Text);
            txtnomeprof.Clear();
            txtidadeprof.Clear();
            txttitprof.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(professor.ImpremeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnomeprof_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
