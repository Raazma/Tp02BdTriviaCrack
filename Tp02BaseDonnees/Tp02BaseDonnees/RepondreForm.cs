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
   public partial class RepondreForm : Form
   {
       bool bonneReponse = false;
      public RepondreForm(int catPiger)
      {
         InitializeComponent();
         SetCat(catPiger);
      }

      private void SetCat(int catpiger)
      {
          SetColor(catpiger);
          SetCatName(catpiger);
      }

      private void SetColor(int catpiger)
      {
          switch (catpiger)
          {
                
              case 1:
                  Pn_couleur.BackColor = Color.Blue;
                  Application.DoEvents();
                  break;
              case 2:
                  Pn_couleur.BackColor = Color.Green;
                  Application.DoEvents();
                  break;
              case 3:
                  Pn_couleur.BackColor = Color.Yellow;
                  Application.DoEvents();
                  break;
              case 4:
                  Pn_couleur.BackColor = Color.Orange;
                  Application.DoEvents();
                  break;
              case 5:
                  Pn_couleur.BackColor = Color.Red;
                  Application.DoEvents();
                  break;
              case 6:
                  Pn_couleur.BackColor = Color.Pink;
                  Application.DoEvents();
                  break;
              case 7:
                  Pn_couleur.BackColor = Color.White;
                  Application.DoEvents();
                  break;

              default:
                  Pn_couleur.BackColor = Color.Black;
                  Application.DoEvents();
                  break;
          }
      }

      private void SetCatName(int catpiger)
      {
          switch (catpiger)
          {
              case 1:
                  Lb_Cat.Text = "Geographie";
                  break;
              case 2:
                  Lb_Cat.Text = "Science";

                  break;
              case 3:
                  Lb_Cat.Text = "Histoire";
                  break;
              case 4:
                  Lb_Cat.Text = "Sport";
                  break;
              case 5:
                  Lb_Cat.Text = "Art";
                  break;
              case 6:
                  Lb_Cat.Text = "Divertissement";
                  break;
              case 7:
                  Lb_Cat.Text = "CHOOSE ONE!!!!!";
                  break;

              default:
                  Lb_Cat.Text = "Anonymouusss";
                  break;
          }                                                    
      }

      private void Btn_A_Click(object sender, EventArgs e)
      {

      }

      private void Btn_B_Click(object sender, EventArgs e)
      {

      }

      private void Btn_C_Click(object sender, EventArgs e)
      {

      }

      private void Btn_D_Click(object sender, EventArgs e)
      {

      }

   }
}
