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
         this.Show();      
      }

      private void Btn_Solo_Click(object sender, EventArgs e)
      {
          AliasForm form = new AliasForm(0);
          String[]  alias= new String[1];
         
          this.Hide();
          form.ShowDialog();
         alias[0] = form.Name;
          Jeu formjeu = new Jeu(alias,0);
          formjeu.ShowDialog();
          this.Close();
      }

      private void Btn_Two_Click(object sender, EventArgs e)
      {         
          String[]  alias= new String[2];       
          this.Hide();
          for (int i = 0; i < 2; i++)
          { 
             AliasForm form = new AliasForm(i);
             form.ShowDialog();   
              alias[i] = form.Name;          
          }
          Jeu formjeu = new Jeu(alias,0);
          formjeu.ShowDialog();
          this.Close();
      }

      private void Btn_Tree_Click(object sender, EventArgs e)
      {
          String[] alias = new String[3];     
          this.Hide();
          for (int i = 0; i < 3; i++)
          {
             AliasForm form = new AliasForm(i);
             alias[i] = form.Name;   
             form.ShowDialog();
          }
          Jeu formjeu = new Jeu(alias,0);
          formjeu.ShowDialog();
          this.Close();
      }

      private void Btn_Four_Click(object sender, EventArgs e)
      {
          String[] alias = new String[4];     
          
          this.Hide();
          for (int i = 0; i < 4; i++)
          {
             AliasForm form = new AliasForm(i);
             alias[i] = form.Name;   
             form.ShowDialog();
          }
          Jeu formjeu = new Jeu(alias,0);
          formjeu.ShowDialog();
          this.Close();
      }

      private void Btn_Quitter_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
