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
   public partial class CompteExistant : Form
   {
       OracleConnection Conn;
       public String Name { get; set; }
      public CompteExistant(OracleConnection Conn)
      {
          this.Conn = Conn;
         InitializeComponent();
         SetButton();
      }

      private void Btn_Validation_Click(object sender, EventArgs e)
      {
          OracleCommand comm = new OracleCommand("ValidationAlias", Conn);
          comm.CommandType = CommandType.StoredProcedure;
          comm.CommandText = "GESTIONJOUEUR.ValidationAlias";

          OracleParameter Ret = new OracleParameter("ret", OracleDbType.Int32);
          Ret.Direction = ParameterDirection.ReturnValue;

          OracleParameter Al = new OracleParameter("PAlias", OracleDbType.Varchar2);
          Al.Direction = ParameterDirection.Input;//reste a faire la validation que lalias existe belle et bien dans la bd


          Al.Value = Tb_Alias.Text;

          comm.Parameters.Add(Ret);
          comm.Parameters.Add(Al);
          comm.ExecuteNonQuery();

          if (int.Parse(Ret.Value.ToString()) == 0)
              Tb_Alias.BackColor = Color.Red;
          else
          {
            Name = Tb_Alias.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
          }
              
         
      }

      private void Btn_Annuler_Click(object sender, EventArgs e)
      {
          this.DialogResult = DialogResult.Cancel;
          this.Close();
      }

      private void SetButton()
      {
          if (Tb_Alias.Text != "")
          {
              Btn_Validation.Enabled = true;
          }
          else
          {
              Btn_Validation.Enabled = false;
          }
      
      }

      private void Tb_Alias_TextChanged(object sender, EventArgs e)
      {
          SetButton();
      }

      private void CompteExistant_Load(object sender, EventArgs e)
      {

      }
   }
}
