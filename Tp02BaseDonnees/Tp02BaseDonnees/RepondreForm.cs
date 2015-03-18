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
         SetCat(catPiger);
         con = Conn;
        
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
         OracleCommand comm = new OracleCommand("GetQuestion", Conn);
         comm.CommandType = CommandType.StoredProcedure;
         comm.CommandText = "GestionQuestion.PigerQuestion";

         OracleParameter LeCode = new OracleParameter("Code", OracleDbType.Char, 1);        
         LeCode.Direction = ParameterDirection.Input;
         LeCode.Value = Code;

         OracleParameter Rand = new OracleParameter("leRand", OracleDbType.Int32);
         Rand.Direction = ParameterDirection.Input;
         Rand.Value = GetRand();

         OracleParameter Ques = new OracleParameter("ques", OracleDbType.RefCursor);
         Ques.Direction = ParameterDirection.ReturnValue;
      
         comm.Parameters.Add(Ques);
         comm.Parameters.Add(LeCode);
         comm.Parameters.Add(Rand);

         OracleDataAdapter Question = new OracleDataAdapter(comm);
        Question.Fill(LesQuestion, "Questions");
        
         BindInfo();
      
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
         return rand.Next(1, 2);
      }
      private void RepondreForm_Load(object sender, EventArgs e)
      {

      }

   }
}
