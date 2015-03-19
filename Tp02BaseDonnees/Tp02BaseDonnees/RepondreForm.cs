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
   public partial class RepondreForm : Form
   {
       OracleConnection Conn;
       DataSet LesQuestion = new DataSet();
       String[] Alias;      
       int NumPartie;
       string Categorie;
       string[] numQuestion = new string[4];
       int tour;
       public bool Continu { get; set; }
      public RepondreForm(int catPiger , OracleConnection con , String[] Alias,int NumPartie , int tour)
      {
         InitializeComponent();
         this.Conn = con;
         SetCat(catPiger);
         this.Alias = Alias;
         this.NumPartie = NumPartie;
         this.tour = tour;
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
                  GetQuestion("B");
                  Categorie = "B";
                  Application.DoEvents();
                  break;
              case 2:
                  Pn_couleur.BackColor = Color.Green;
                  GetQuestion("V");
                  Categorie = "V";
                  Application.DoEvents();
                  break;
              case 3:
                  Pn_couleur.BackColor = Color.Yellow;
                 GetQuestion("J");
                 Categorie = "J";
                  Application.DoEvents();
                  break;
              case 4:
                  Pn_couleur.BackColor = Color.Orange;
                  GetQuestion("O");
                  Categorie = "O";
                  Application.DoEvents();
                  break;
              case 5:
                  Pn_couleur.BackColor = Color.Red;
                  GetQuestion("R");
                  Categorie = "R";
                  Application.DoEvents();
                  break;
              case 6:
                  Pn_couleur.BackColor = Color.Pink;
                GetQuestion("P");
                Categorie = "P";
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
          Continu = Validate(numQuestion[0]);
          Btn_A.BackColor = Continu ? Color.Green : Color.Red;
          Application.DoEvents();
          System.Threading.Thread.Sleep(1000);
          GEstionReponse(b);
          //code tableau score
          this.DialogResult = DialogResult.OK;
          this.Close();

      }

      private void Btn_B_Click(object sender, EventArgs e)
      {
          Continu = Validate(numQuestion[1]);
          Btn_B.BackColor = Continu ? Color.Green : Color.Red;
          Application.DoEvents();
          System.Threading.Thread.Sleep(1000);
          GEstionReponse(b);
          //code tableau score
          this.DialogResult = DialogResult.OK;
          this.Close();
      }

      private void Btn_C_Click(object sender, EventArgs e)
      {
          Continu = Validate(numQuestion[2]);
          Btn_C.BackColor = Continu ? Color.Green : Color.Red;
          Application.DoEvents();
          System.Threading.Thread.Sleep(1000);
          GEstionReponse(b);
          //code tableau score
          this.DialogResult = DialogResult.OK;
          this.Close();
      }

      private void Btn_D_Click(object sender, EventArgs e)
      {
          Continu = Validate(numQuestion[3]);
          Btn_D.BackColor = Continu ? Color.Green : Color.Red;
          Application.DoEvents();
          System.Threading.Thread.Sleep(1000);
          GEstionReponse(b);
          //code tableau score
          this.DialogResult = DialogResult.OK;
          this.Close();
      }
       private bool Validate(string rep)
      {
          OracleCommand comm = new OracleCommand("GetQuestion", Conn);
          comm.CommandType = CommandType.StoredProcedure;
          comm.CommandText = "GESTIONQUESTION.VerifierSiLaBonneReponse";

          OracleParameter Ret = new OracleParameter("ret", OracleDbType.Int32);
          Ret.Direction = ParameterDirection.ReturnValue;

          OracleParameter Rep = new OracleParameter("PNumReponse", OracleDbType.Char,8);
          Rep.Direction = ParameterDirection.Input;

          OracleParameter Al = new OracleParameter("PAlias", OracleDbType.Varchar2,20);
          Al.Direction = ParameterDirection.Input;

          OracleParameter Cat = new OracleParameter("PCat", OracleDbType.Char, 1);
          Cat.Direction = ParameterDirection.Input;

          OracleParameter Parti = new OracleParameter("PParti", OracleDbType.Int32);
          Parti.Direction = ParameterDirection.Input;

          Rep.Value = rep;
          Al.Value = Alias[tour];
          Cat.Value = Categorie;
          Parti.Value = NumPartie;

          comm.Parameters.Add(Ret);
          comm.Parameters.Add(Rep);
          comm.Parameters.Add(Al);
          comm.Parameters.Add(Cat);
          comm.Parameters.Add(Parti);

          comm.ExecuteNonQuery();

          return int.Parse( Ret.Value.ToString()) == 0;                  
      }
      private void GetQuestion(String Code)
      {
         Clear();
        int LeRand = GetRand();
         OracleCommand comm = new OracleCommand("GetQuestion", Conn);
         comm.CommandType = CommandType.StoredProcedure;
         comm.CommandText = "GESTIONQUESTION.PigerQuestion";

         OracleParameter Ques = new OracleParameter("ques", OracleDbType.RefCursor);
         Ques.Direction = ParameterDirection.ReturnValue;

         OracleParameter LeCode = new OracleParameter("Code", OracleDbType.Char, 8);
         LeCode.Direction = ParameterDirection.Input;
         LeCode.Value = Code + GetRand();

         OracleParameter Rand = new OracleParameter("leRand", OracleDbType.Int32);
         Rand.Direction = ParameterDirection.Input;
         Rand.Value = LeRand;

         comm.Parameters.Add(Ques);
         comm.Parameters.Add(LeCode);
         comm.Parameters.Add(Rand);

         OracleDataAdapter Question = new OracleDataAdapter(comm);
         Question.Fill(LesQuestion, "Questions");
         BindInfo();

        Btn_A.Text = GetReponse(Code+LeRand + "A");
        numQuestion[0] = Code + LeRand + "A";
        Btn_B.Text = GetReponse(Code+LeRand + "B");
        numQuestion[1] = Code + LeRand + "B";
        Btn_C.Text = GetReponse(Code+LeRand + "C");
        numQuestion[2] = Code + LeRand + "C";
        Btn_D.Text = GetReponse(Code+LeRand + "D");
        numQuestion[3] = Code + LeRand + "D";
      }

      private void BindInfo()
      {
         Lb_Question.DataBindings.Add("text", LesQuestion, "Questions.Enoncer");              
      }
      private void Clear()
      {
         LesQuestion.Clear();
         Lb_Question.DataBindings.Clear();
      }
      private int  GetRand()
      {
         Random rand = new Random();
         return rand.Next(1, 1);
      }
      private void RepondreForm_Load(object sender, EventArgs e)
      {

      }
      private String GetReponse(String CodeCat)
      {
         OracleCommand comm = new OracleCommand("GetQuestion", Conn);
         comm.CommandType = CommandType.StoredProcedure;
         comm.CommandText = "GestionQuestion.GetRep";

         OracleParameter Rep = new OracleParameter("LaRep", OracleDbType.Varchar2, 60);
         Rep.Direction = ParameterDirection.ReturnValue;

         OracleParameter CodeRep = new OracleParameter("Code", OracleDbType.Char, 8);
         CodeRep.Direction = ParameterDirection.Input;
         CodeRep.Value = CodeCat;

         comm.Parameters.Add(Rep);
         comm.Parameters.Add(CodeRep);

         comm.ExecuteNonQuery();

         return Rep.Value.ToString();
        
      }
      private void GEstionReponse(bool b)
      { 
      
       if(b)
       {
          FormScoreJ form = new FormScoreJ(Alias,tour,tour,true,Conn);
          this.Hide();
          form.ShowDialog();
          this.Close();
       }
       else
       {
          FormScoreJ form = new FormScoreJ(Alias, tour, tour++, false,Conn);
          this.Hide();
          form.ShowDialog();
          this.Close();
      }

   }
}
}
