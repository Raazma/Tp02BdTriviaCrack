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
      }

      private void Btn_Validation_Click(object sender, EventArgs e)
      {
         //reste a faire la validation que lalias existe belle et bien dans la bd
         Name = Tb_Alias.Text;

      }
   }
}
