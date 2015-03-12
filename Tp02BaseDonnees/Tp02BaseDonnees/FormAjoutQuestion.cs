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
   public partial class FormAjoutQuestion : Form
   {
      OracleConnection oraconn = new OracleConnection();
      public FormAjoutQuestion()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         Connection();
         StartingState();
      }

      private void Connection()
      {
         string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
              "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
         string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  lemairef;PASSWORD = ORACLE1";
         try
         {
            oraconn.ConnectionString = chainedeconnexion;
            oraconn.Open();          
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }                 
      }

      private void StartingState()
      {
         Cb_Categories.SelectedIndex = 0;
         Cb_Rep.SelectedIndex = 0;                            
      }

      private void Btn_Enregistrer_Click(object sender, EventArgs e)
      {      
         Insertion();
      }
      private void Insertion()
      {
         OracleCommand com = new OracleCommand("Insert", oraconn);
         com.CommandType = CommandType.StoredProcedure;
         com.CommandText = "GESTIONQUESTION.INSERTION";

         OracleParameter numQ = new OracleParameter("numQ", OracleDbType.Char, 8);
         numQ.Direction = ParameterDirection.Input;
         String CodeQ = FormatedString();
         numQ.Value = CodeQ;
         OracleParameter enoncer = new OracleParameter("Question", OracleDbType.Varchar2, 80);
         enoncer.Direction = ParameterDirection.Input;
         enoncer.Value = Tb_Question.Text;

         OracleParameter CodeCat = new OracleParameter("codecat", OracleDbType.Char, 1);
         CodeCat.Direction = ParameterDirection.Input;
         CodeCat.Value = ReadCodeCat();

         com.Parameters.Add(numQ);
         com.Parameters.Add(enoncer);
         com.Parameters.Add(CodeCat);
         com.ExecuteNonQuery();

         InsertRep(CodeQ);       
      }

      private void InsertRep(String Code)
      {

         OracleCommand com = new OracleCommand("Insert", oraconn);
         com.CommandType = CommandType.StoredProcedure;
         com.CommandText = "GESTIONQUESTION.InsertRep";

         OracleParameter NumRep = new OracleParameter("numRep",OracleDbType.Char,8);
         NumRep.Direction = ParameterDirection.Input;
         NumRep.Value = Code + 'A';

         OracleParameter Descrip = new OracleParameter("descri", OracleDbType.Varchar2,60);
         Descrip.Direction = ParameterDirection.Input;
         Descrip.Value = Tb_A.Text;
         
        OracleParameter Flag = new OracleParameter("leflag",OracleDbType.Char,1);
        Flag.Direction = ParameterDirection.Input;
        Flag.Value = CreateFlag("A");

         OracleParameter codeq = new OracleParameter("codeq", OracleDbType.Char, 8);
         codeq.Direction = ParameterDirection.Input;
         codeq.Value = Code;

         com.Parameters.Add(NumRep);
         com.Parameters.Add(Descrip);
         com.Parameters.Add(Flag);
         com.Parameters.Add(codeq);

         com.ExecuteNonQuery();

         NumRep.Value = Code + 'B';
         Descrip.Value = Tb_B.Text;
         Flag.Value = CreateFlag("B");
         com.ExecuteNonQuery();

         NumRep.Value = Code + 'C';
         Descrip.Value = Tb_C.Text;
         Flag.Value = CreateFlag("C");
         com.ExecuteNonQuery();

         NumRep.Value = Code + 'D';
         Descrip.Value = Tb_D.Text;
         Flag.Value = CreateFlag("D");
         com.ExecuteNonQuery();

      }

      private char CreateFlag(String letter)
      {
         return (letter == Cb_Rep.SelectedItem.ToString()) ? 'V' : 'F';           
      }
      private String FormatedString()
      {
         return ReadCodeCat() + (CountnbQuestion(ReadCodeCat()) + 1).ToString();            
      }
      private String ReadCodeCat()
      {
         String Query = "Select CodeCategorie from Categorie where NomCategorie = '" + Cb_Categories.SelectedItem.ToString() + "'";
         OracleCommand comm = new OracleCommand(Query, oraconn);
         OracleDataReader reader = comm.ExecuteReader();
         String Data = "";

         while(reader.Read())
         {
         Data = reader.GetString(0);          
         }
         return Data;
      }
      private int CountnbQuestion(String code)
      {
         try
         {
            OracleCommand com = new OracleCommand("nombre", oraconn);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "GESTIONQUESTION.GETNBQUESTION";

            OracleParameter nb = new OracleParameter("nb", OracleDbType.Int32);
            nb.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(nb);

            OracleParameter lecode = new OracleParameter("code", OracleDbType.Char, 1);
            lecode.Direction = ParameterDirection.Input;
            lecode.Value = code;
            com.Parameters.Add(lecode);
            com.ExecuteNonQuery();
           
            return int.Parse(nb.Value.ToString());
         }
         catch (Exception e)
         {
            MessageBox.Show(e.ToString());
         
         }
         return -1;
      
      }

      
   }
}
