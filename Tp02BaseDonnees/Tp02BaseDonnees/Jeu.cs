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
   public partial class Jeu : Form
   {
      int numTour = 0;
      String[] tabAlias;
      OracleConnection LaCon;
      int NumPartie;
      public Jeu(String[] alias, int tour, OracleConnection con)
      {
         InitializeComponent();
         tabAlias = alias;
         numTour = tour;
         LaCon = con;
         AfficherAlias();
         NumPartie = generateGameId();
      }
       private int generateGameId()
      {
          OracleCommand comm = new OracleCommand("StartGame", LaCon);
          comm.CommandType = CommandType.StoredProcedure;
          comm.CommandText = "GESTIONQUESTION.StartGame";

          OracleParameter Ret = new OracleParameter("ret", OracleDbType.Int32);
          Ret.Direction = ParameterDirection.ReturnValue;

          comm.Parameters.Add(Ret);
         
          comm.ExecuteNonQuery();
          return int.Parse(Ret.Value.ToString());
      }
       

      private void Btn_Spin_Click(object sender, EventArgs e)
      {
         int Rcolor = 0;
         Random rnd = new Random();

         for (int i = 0; i < 15; i++)
         {
            Rcolor = rnd.Next(1, 8);
            ColorChanger(Rcolor);

         }

         System.Threading.Thread.Sleep(1000);

         if (Rcolor == 7)
         {
           this.Hide();
            ChooseCategorie ChoixCat = new ChooseCategorie();
            if(ChoixCat.ShowDialog()==DialogResult.OK)
                Rcolor=ChoixCat.choix;
            this.Close();
         }
        RepondreForm Question = new RepondreForm(Rcolor, LaCon, tabAlias, NumPartie, numTour);
        this.Hide();
        if(Question.ShowDialog()==DialogResult.OK)
            if(!Question.Continu)
            {
                if (numTour + 1 >= tabAlias.Length)
                    numTour = -1;
                numTour++;
            }
          //if(
        AfficherAlias();       

        this.Show();
         

      }

      private void ColorChanger(int i)
      {
         switch (i)
         {
            case 1:
               Pn_Color.BackColor = Color.Blue;
               SetCategorieName(1);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 2:
               Pn_Color.BackColor = Color.Green;
               SetCategorieName(2);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 3:
               Pn_Color.BackColor = Color.Yellow;
               SetCategorieName(3);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 4:
               Pn_Color.BackColor = Color.Orange;
               SetCategorieName(4);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 5:
               Pn_Color.BackColor = Color.Red;
               SetCategorieName(5);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 6:
               Pn_Color.BackColor = Color.Pink;
               SetCategorieName(6);
               Application.DoEvents();
               System.Threading.Thread.Sleep(100);
               break;
            case 7:
               Pn_Color.BackColor = Color.White;
               SetCategorieName(7);
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
               Lb_NomCat.Text = "Science";

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

      private void AfficherAlias()
      {

         Lb_Nom.Text = "Tour De " + tabAlias[numTour];

      }

      private void CreateNumPartie()
      { 
        OracleCommand comm = new OracleCommand("GetnumGame",LaCon);
        comm.CommandType = CommandType.StoredProcedure;
        comm.CommandText = "GestionQuestion.StartGame";

        OracleParameter Num = new OracleParameter("Num", OracleDbType.Int32);
        Num.Direction = ParameterDirection.ReturnValue;

        comm.Parameters.Add(Num);
        comm.ExecuteNonQuery();
        NumPartie = int.Parse(Num.Value.ToString());
                  
      }

      private void Jeu_Load(object sender, EventArgs e)
      {

      }
   }
}

