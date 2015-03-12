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
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void Btn_Jouer_Click(object sender, EventArgs e)
        {
            Jeu form = new Jeu();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
