using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu.cs
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testeForm1 tst1 = new testeForm1();
            tst1.MdiParent = this;
            tst1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testeForm2 tst2 = new testeForm2();
            tst2.MdiParent = this;
            tst2.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            lblHora.Text = "Hora :" + DateTime.Now.ToString(" HH/mm/ss");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data :" + DateTime.Now.ToString(" dd/MM/yyyy");
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");

            else {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
