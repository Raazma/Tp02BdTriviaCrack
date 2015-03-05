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
   public partial class Menu : Form
   {
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

         Pn_Solo.Text = "Solo Joueur";
         Pn_Two.Text = "2 Joueurs";
         Pn_Tree.Text = "3 Joueurs";
         Pn_Four.Text = "4 Joueurs";


      }

      private void TB_Solo_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
