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
       bool bonneReponse = false;
       OracleConnection Conn;
       DataSet LesQuestion = new DataSet();
      public RepondreForm(int catPiger , OracleConnection con)
      {
         InitializeComponent();
         this.Conn = con;
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
                  GetQuestion("B");
                  Application.DoEvents();
                  break;
              case 2:
                  Pn_couleur.BackColor = Color.Green;
                  GetQuestion("V");
                  Application.DoEvents();
                  break;
              case 3:
                  Pn_couleur.BackColor = Color.Yellow;
                 GetQuestion("J");
                  Application.DoEvents();
                  break;
              case 4:
                  Pn_couleur.BackColor = Color.Orange;
                  GetQuestion("O");
                  Application.DoEvents();
                  break;
              case 5:
                  Pn_couleur.BackColor = Color.Red;
                  GetQuestion("R");
                  Application.DoEvents();
                  break;
              case 6:
                  Pn_couleur.BackColor = Color.Pink;
                GetQuestion("P");
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
          GetQuestion("P");
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
        Btn_B.Text = GetReponse(Code+LeRand + "B");
        Btn_C.Text = GetReponse(Code+LeRand + "C");
        Btn_D.Text = GetReponse(Code + LeRand + "D");

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
         return rand.Next(1, 3);
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
         //return "ALLo";
      }

   }
}
