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
    public partial class Form3 : Form
    {
        Aluno aluno;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            aluno = new Aluno(txtnomealun.Text, (Convert.ToInt32(txtidadealun.Text)), txtcursoalu.Text);
            txtnomealun.Clear();
            txtidadealun.Clear();
            txtcursoalu.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aluno.ImpremeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void txtidadealun_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
