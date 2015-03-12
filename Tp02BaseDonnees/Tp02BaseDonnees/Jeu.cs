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
   public partial class Jeu : Form
   {
      public Jeu()
      {
         InitializeComponent();
      }

      private void Btn_Spin_Click(object sender, EventArgs e)
      {
          Random rnd = new Random();
          for (int i = 0; i < 15; i++)
          {                       
              int Rcolor = rnd.Next(1, 8);                          
              ColorChanger(Rcolor);
              SetCategorieName(Rcolor);
           }       
      }

          private void ColorChanger(int i)
          {

            switch (i)
              {               
                  case 1:
                      Pn_Color.BackColor = Color.Blue;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 2:
                      Pn_Color.BackColor = Color.Green;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 3:
                      Pn_Color.BackColor = Color.Yellow;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 4:
                      Pn_Color.BackColor = Color.Orange;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 5:
                      Pn_Color.BackColor = Color.Red;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 6:
                      Pn_Color.BackColor = Color.Pink;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
                  case 7:
                      Pn_Color.BackColor = Color.White;
                      
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;

                  default:
                      Pn_Color.BackColor = Color.Black;
                      Application.DoEvents();
                      System.Threading.Thread.Sleep(100);
                      break;
              }
          
          }
          private void SetCategorieName(int i)
          {
              switch (i)
              {
                  case 1:
                     Lb_NomCat.Text = "Geographie";
                      break;
                  case 2:
                    Lb_NomCat.Text ="Science";
                   
                      break;
                  case 3:
                      Lb_NomCat.Text = "Histoire";
                      break;
                  case 4:
                      Lb_NomCat.Text = "Sport";
                      break;
                  case 5:
                     Lb_NomCat.Text = "Art";
                      break;
                  case 6:
                    Lb_NomCat.Text = "Divertissement";
                      break;
                  case 7:
                     Lb_NomCat.Text = "CHOOSE ONE!!!!!";
                      break;

                  default:
                      Lb_NomCat.Text = "Anonymouusss";
                      break;
              }
                                              
          }

      }
   }

