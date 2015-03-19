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
   public partial class CompteExistant : Form
   {
      String Name { get; set; }
      public CompteExistant()
      {
         InitializeComponent();
         SetButton();
      }

      private void Btn_Validation_Click(object sender, EventArgs e)
      {
         //reste a faire la validation que lalias existe belle et bien dans la bd

         Name = Tb_Alias.Text;
         
      }

      private void Btn_Annuler_Click(object sender, EventArgs e)
      {

      }

      private void SetButton()
      {
          if (Tb_Alias.Text != "")
          {
              Btn_Validation.Enabled = true;
          }
          else
          {
              Btn_Validation.Enabled = false;
          }
      
      }

      private void Tb_Alias_TextChanged(object sender, EventArgs e)
      {
          SetButton();
      }

      private void CompteExistant_Load(object sender, EventArgs e)
      {

      }
   }
}
