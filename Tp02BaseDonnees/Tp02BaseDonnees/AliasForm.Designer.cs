namespace Tp02BaseDonnees
{
   partial class AliasForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.Nom = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_Alias = new System.Windows.Forms.TextBox();
            this.Lb_Alias = new System.Windows.Forms.Label();
            this.Tb_Prenom = new System.Windows.Forms.TextBox();
            this.Lb_renom = new System.Windows.Forms.Label();
            this.Lb_Ident = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(39, 78);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Location = new System.Drawing.Point(93, 75);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(142, 20);
            this.Tb_Name.TabIndex = 1;
            // 
            // Tb_Alias
            // 
            this.Tb_Alias.Location = new System.Drawing.Point(93, 147);
            this.Tb_Alias.Name = "Tb_Alias";
            this.Tb_Alias.Size = new System.Drawing.Size(142, 20);
            this.Tb_Alias.TabIndex = 3;
            // 
            // Lb_Alias
            // 
            this.Lb_Alias.AutoSize = true;
            this.Lb_Alias.Location = new System.Drawing.Point(39, 150);
            this.Lb_Alias.Name = "Lb_Alias";
            this.Lb_Alias.Size = new System.Drawing.Size(29, 13);
            this.Lb_Alias.TabIndex = 2;
            this.Lb_Alias.Tag = "";
            this.Lb_Alias.Text = "Alias";
            // 
            // Tb_Prenom
            // 
            this.Tb_Prenom.Location = new System.Drawing.Point(93, 111);
            this.Tb_Prenom.Name = "Tb_Prenom";
            this.Tb_Prenom.Size = new System.Drawing.Size(142, 20);
            this.Tb_Prenom.TabIndex = 5;
            // 
            // Lb_renom
            // 
            this.Lb_renom.AutoSize = true;
            this.Lb_renom.Location = new System.Drawing.Point(39, 114);
            this.Lb_renom.Name = "Lb_renom";
            this.Lb_renom.Size = new System.Drawing.Size(43, 13);
            this.Lb_renom.TabIndex = 4;
            this.Lb_renom.Text = "Prenom";
            // 
            // Lb_Ident
            // 
            this.Lb_Ident.AutoSize = true;
            this.Lb_Ident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Ident.Location = new System.Drawing.Point(38, 20);
            this.Lb_Ident.Name = "Lb_Ident";
            this.Lb_Ident.Size = new System.Drawing.Size(218, 20);
            this.Lb_Ident.TabIndex = 6;
            this.Lb_Ident.Text = "Au Joueur J a s\'indentifier";
            // 
            // Btn_Login
            // 
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Location = new System.Drawing.Point(93, 183);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(142, 23);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "J\'ai deja un compte";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Create
            // 
            this.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Create.Location = new System.Drawing.Point(93, 212);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(142, 23);
            this.Btn_Create.TabIndex = 8;
            this.Btn_Create.Text = "Enregistrer";
            this.Btn_Create.UseVisualStyleBackColor = true;
            // 
            // AliasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 269);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lb_Ident);
            this.Controls.Add(this.Tb_Prenom);
            this.Controls.Add(this.Lb_renom);
            this.Controls.Add(this.Tb_Alias);
            this.Controls.Add(this.Lb_Alias);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.Nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AliasForm";
            this.Load += new System.EventHandler(this.AliasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Nom;
      private System.Windows.Forms.TextBox Tb_Name;
      private System.Windows.Forms.TextBox Tb_Alias;
      private System.Windows.Forms.Label Lb_Alias;
      private System.Windows.Forms.TextBox Tb_Prenom;
      private System.Windows.Forms.Label Lb_renom;
      private System.Windows.Forms.Label Lb_Ident;
      private System.Windows.Forms.Button Btn_Login;
      private System.Windows.Forms.Button Btn_Create;
   }
}