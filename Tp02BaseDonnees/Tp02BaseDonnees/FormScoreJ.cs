using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Tp02BaseDonnees
{
   public partial class FormScoreJ : Form
   {
      String[] alias;
       int tourActuelle;
      int nouveauTour;
      bool BonneRep;
      OracleConnection conn;
      public FormScoreJ(String[] alias,int tourA,int TourN , bool BonneRep , OracleConnection conn)
      {
         InitializeComponent();
         SetButtonText();
         this.conn = conn;
         this.alias = alias;
         tourActuelle = tourA;
         nouveauTour = TourN;
         this.BonneRep = BonneRep;
      }

      private void FormScoreJ_Load(object sender, EventArgs e)
      {


      }
      private void  SetButtonText()
      {
         if (!BonneRep)
            Btn_Continue.Text = "Prochain Joueur";
      
      }

      private void Btn_Continue_Click(object sender, EventArgs e)
      {
         Jeu form = new Jeu(alias, nouveauTour, conn);
         this.Hide();
         form.ShowDialog();
         this.Close();
      }

     
   }
}
