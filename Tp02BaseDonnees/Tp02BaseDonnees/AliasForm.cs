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
   public partial class AliasForm : Form
   {
      OracleConnection Conn;
      public int i;
      public String Name { get; set; }
      public AliasForm()
      {
         InitializeComponent();
         SetSetting();
      }
      public AliasForm(int i ,   OracleConnection con)
      {
         InitializeComponent();
         Conn = con;
         this.i = i;
         Lb_Ident.Text = "Au Joueur "+( i + 1 )+ " a s'indentifier";
         SetSetting();
      }
      private void AliasForm_Load(object sender, EventArgs e)
      {

      }
      private void Btn_Login_Click(object sender, EventArgs e)
      {
          CompteExistant form = new CompteExistant();
          this.Hide();
          form.ShowDialog();
          if (form.DialogResult == DialogResult.OK)
          {
             Name = form.Name;           
          }
          else
          {
             this.Show();         
          }
      }
      private void Btn_Create_Click(object sender, EventArgs e)
      {
         Name = Tb_Alias.Text;
         InsertPlayer(Name, Tb_Name.Text, Tb_Prenom.Text);
         //rentrer le reste des infos dans la bd;
      }

       private void SetSetting()
       {
           if (Tb_Alias.Text != "" && Tb_Name.Text != "" && Tb_Prenom.Text != "")
           {
               Btn_Create.Enabled = true;

           }
           else
           {
               Btn_Create.Enabled = false;
           }
       
       }

       private void Tb_Name_TextChanged(object sender, EventArgs e)
       {
           SetSetting();
       }
       private void Tb_Prenom_TextChanged(object sender, EventArgs e)
       {
           SetSetting();
       }

       private void Tb_Alias_TextChanged(object sender, EventArgs e)
       {
           SetSetting();
       }
       private void InsertPlayer(String Alias, String Ln, String Fn)
       {

          OracleCommand com = new OracleCommand("InsertJoueur", Conn);
          com.CommandType = CommandType.StoredProcedure;
          com.CommandText = "GestionJoueur.InsertionJoueur";

          OracleParameter Al = new OracleParameter("al", OracleDbType.Varchar2, 20);
          Al.Direction = ParameterDirection.Input;
          Al.Value = Alias;

          OracleParameter N = new OracleParameter("LN", OracleDbType.Varchar2, 40);
          N.Direction = ParameterDirection.Input;
          N.Value = Ln;

          OracleParameter P = new OracleParameter("Pn", OracleDbType.Varchar2, 40);
          P.Direction = ParameterDirection.Input;
          P.Value = Fn;

          com.Parameters.Add(Al);
          com.Parameters.Add(N);
          com.Parameters.Add(P);

          com.ExecuteNonQuery();
       
       }
    
   }
}
