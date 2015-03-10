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



      }

      private void TB_Solo_TextChanged(object sender, EventArgs e)
      {

      }

      private void Btn_Question_Click(object sender, EventArgs e)
      {
         FormAjoutQuestion form = new FormAjoutQuestion();
         this.Hide();
         form.ShowDialog();
         this.Close();
       
      }
   }
}
