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
   public partial class AliasForm : Form
   {
      public AliasForm()
      {
         InitializeComponent();
      }

      private void AliasForm_Load(object sender, EventArgs e)
      {

      }

      private void Btn_Login_Click(object sender, EventArgs e)
      {
          CompteExistant form = new CompteExistant();
          this.Hide();
          form.ShowDialog();
          if (form.DialogResult == DialogResult.OK)
          {
              this.Close();
          }
          else
          {
              this.Show();         
          }
      }

    
   }
}
