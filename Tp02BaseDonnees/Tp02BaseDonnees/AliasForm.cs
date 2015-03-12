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
      public int i;
      public String Name { get; set; }
      public AliasForm()
      {
         InitializeComponent();
      }
      public AliasForm(int i)
      {
         InitializeComponent();
         this.i = i;
         Lb_Ident.Text = "Au Joueur "+( i + 1 )+ " a s'indentifier";
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
             Name = form.Name;
              this.Close();
          }
          else
          {
              this.Show();         
          }
      }

      private void Btn_Create_Click(object sender, EventArgs e)
      {
         Name = Tb_Alias.Text;
        
         //rentrer le reste des infos dans la bd;
      }

    
   }
}
