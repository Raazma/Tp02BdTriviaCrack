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
   public partial class Form1 : Form
   {
      OracleConnection oraconn = new OracleConnection();
      public Form1()
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
         //OracleCommand com = new OracleCommand("Insert", oraconn);
         //com.CommandType = CommandType.StoredProcedure;
         //com.CommandText = "GESTIONQUESTION.INSERTION";

         //OracleParameter numQ =  new OracleParameter("numQ",OracleDbType.Char,8);
         //numQ.Direction = ParameterDirection.Input;

         //OracleParameter enoncer = new OracleParameter("Question",OracleDbType.Varchar2,80);
         //enoncer.Direction = ParameterDirection.Input;
         //enoncer.Value = Tb_Question.Text;

         //OracleParameter CodeCat = new OracleParameter("codecat",OracleDbType.Char,1);
         //CodeCat.Direction = ParameterDirection.Input;

         MessageBox.Show(CountnbQuestion('V').ToString());

      }
     
      private int CountnbQuestion(Char code)
      {

         try
         {
            OracleCommand com = new OracleCommand("nombre", oraconn);
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "GESTIONQUESTION.GETNBQUESTION";

            OracleParameter nb = new OracleParameter("nb", OracleDbType.Int32);
            nb.Direction = ParameterDirection.ReturnValue;
            com.Parameters.Add(nb);

            OracleParameter lecode = new OracleParameter("codee", OracleDbType.Char, 1);
            lecode.Direction = ParameterDirection.Input;
            lecode.Value = code;
            com.Parameters.Add(lecode);
            com.ExecuteNonQuery();
            return int.Parse(nb.ToString());
         }
         catch (Exception e)
         {
            MessageBox.Show(e.ToString());
         
         }
         return 1;
      
      }

      
   }
}
