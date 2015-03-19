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
    public partial class Menu : Form
    {
        OracleConnection oraconn = new OracleConnection();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SetDefault();
        }
        private void SetDefault()
        {
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  lemairef;PASSWORD = ORACLE1";
            try
            {
                oraconn.ConnectionString = chainedeconnexion;
                oraconn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void TB_Solo_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btn_Question_Click(object sender, EventArgs e)
        {
            FormAjoutQuestion form = new FormAjoutQuestion();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Btn_Solo_Click(object sender, EventArgs e)
        {
            AliasForm form = new AliasForm(0, oraconn);
            String[] alias = new String[1];

            this.Hide();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                alias[0] = form.Name;
                Jeu formjeu = new Jeu(alias, 0, oraconn);
                formjeu.ShowDialog();
                this.Close();
            }
            else
                this.Show();

        }

        private void Btn_Two_Click(object sender, EventArgs e)
        {
            String[] alias = new String[2];
            this.Hide();
            for (int i = 0; i < 2; i++)
            {
                AliasForm form = new AliasForm(i, oraconn);
                form.ShowDialog();
                alias[i] = form.Name;
            }
            Jeu formjeu = new Jeu(alias, 0, oraconn);
            formjeu.ShowDialog();
            this.Close();
        }

        private void Btn_Tree_Click(object sender, EventArgs e)
        {
            String[] alias = new String[3];
            this.Hide();
            for (int i = 0; i < 3; i++)
            {
                AliasForm form = new AliasForm(i, oraconn);
                alias[i] = form.Name;
                form.ShowDialog();
            }
            Jeu formjeu = new Jeu(alias, 0, oraconn);
            formjeu.ShowDialog();
            this.Close();
        }

        private void Btn_Four_Click(object sender, EventArgs e)
        {
            String[] alias = new String[4];

            this.Hide();
            for (int i = 0; i < 4; i++)
            {
                AliasForm form = new AliasForm(i, oraconn);
                alias[i] = form.Name;
                form.ShowDialog();
            }
            Jeu formjeu = new Jeu(alias, 0, oraconn);
            formjeu.ShowDialog();
            this.Close();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
