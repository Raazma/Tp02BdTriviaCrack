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
      int numPartie;
      OracleConnection conn;
      DataSet Data = new DataSet();
      
      public FormScoreJ(String[] alias,int tourA, int numPartie , bool BonneRep , OracleConnection conn)
      {
         InitializeComponent();
      
         this.conn = conn;
         this.alias = alias;
         tourActuelle = tourA;
         this.numPartie =  numPartie;
         this.BonneRep = BonneRep;
         AjoutScore();
         SetButtonText();
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
         this.Close();
      }

      private void AjoutScore()
      { 
       ClearBinding();
      OracleCommand com = new OracleCommand("InsertGrep",conn);
      com.CommandType = CommandType.StoredProcedure;
      com.CommandText = "GestionJoueur.GetScoreJ";

      OracleParameter alias = new OracleParameter("alias", OracleDbType.Varchar2, 20);
      alias.Direction = ParameterDirection.Input;
      alias.Value = this.alias[tourActuelle];


      OracleParameter Num = new OracleParameter("Num", OracleDbType.Int32);
     Num.Direction = ParameterDirection.Input;
     Num.Value = numPartie;

     OracleParameter Score = new OracleParameter("leScore", OracleDbType.RefCursor);
      Score.Direction = ParameterDirection.ReturnValue;

       com.Parameters.Add(Score);
       com.Parameters.Add(alias);
       com.Parameters.Add(Num);

       OracleDataAdapter adp = new OracleDataAdapter(com);
       adp.Fill(Data,"LeScore");

         BindInfo();
      
      }
      private void BindInfo()
      {


         Lb_bleu.DataBindings.Add("Text", Data, "LeScore.B");
         Lb_Vert.DataBindings.Add("Text", Data, "LeScore.V");
         Lb_Jaune.DataBindings.Add("Text", Data, "LeScore.J");
         Lb_Orange.DataBindings.Add("Text", Data, "LeScore.O");
         Lb_Rouge.DataBindings.Add("Text", Data, "LeScore.R");
         Lb_Rose.DataBindings.Add("Text", Data, "LeScore.P");
                 
      }
     private void ClearBinding()
     {
         Data.Clear();
        Lb_bleu.DataBindings.Clear();
        Lb_Jaune.DataBindings.Clear();
        Lb_Orange.DataBindings.Clear();
        Lb_Rouge.DataBindings.Clear();
        Lb_Vert.DataBindings.Clear();
        Lb_Rose.DataBindings.Clear();
      
     }

   }
}
