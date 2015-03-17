using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp02BaseDonnees
{
    public partial class ChooseCategorie : Form
    {
        public ChooseCategorie()
        {
            InitializeComponent();
        }

      

        private void Btn_Bleu_Click(object sender, EventArgs e)
        {
            RepondreForm form = new RepondreForm(1);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Green_Click(object sender, EventArgs e)
        {
            RepondreForm form = new RepondreForm(2);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Yellow_Click(object sender, EventArgs e)
        {

            RepondreForm form = new RepondreForm(3);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Orange_Click(object sender, EventArgs e)
        {
            RepondreForm form = new RepondreForm(4);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
            RepondreForm form = new RepondreForm(5);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Btn_Pink_Click(object sender, EventArgs e)
        {
            RepondreForm form = new RepondreForm(6);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
