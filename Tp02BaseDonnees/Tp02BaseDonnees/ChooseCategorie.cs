using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Tp02BaseDonnees
{
    public partial class ChooseCategorie : Form
    {
        OracleConnection Lacon;

        public int choix { get; set; }
        public ChooseCategorie()
        {
            InitializeComponent();

        }



        private void Btn_Bleu_Click(object sender, EventArgs e)
        {
            choix = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Btn_Green_Click(object sender, EventArgs e)
        {
            choix = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Yellow_Click(object sender, EventArgs e)
        {

            choix = 3;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Orange_Click(object sender, EventArgs e)
        {
            choix = 4;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_red_Click(object sender, EventArgs e)
        {
            choix = 5;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Pink_Click(object sender, EventArgs e)
        {
            choix = 6;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
