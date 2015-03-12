namespace Tp02BaseDonnees
{
   partial class Jeu
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
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.Pn_Color = new System.Windows.Forms.Panel();
            this.Lb_NomCat = new System.Windows.Forms.Label();
            this.Lb_Nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Spin.Location = new System.Drawing.Point(106, 370);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(200, 45);
            this.Btn_Spin.TabIndex = 8;
            this.Btn_Spin.Text = "SPIN";
            this.Btn_Spin.UseVisualStyleBackColor = true;
            this.Btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // Pn_Color
            // 
            this.Pn_Color.BackColor = System.Drawing.Color.Black;
            this.Pn_Color.Location = new System.Drawing.Point(103, 140);
            this.Pn_Color.Name = "Pn_Color";
            this.Pn_Color.Size = new System.Drawing.Size(200, 100);
            this.Pn_Color.TabIndex = 9;
            // 
            // Lb_NomCat
            // 
            this.Lb_NomCat.AutoSize = true;
            this.Lb_NomCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NomCat.Location = new System.Drawing.Point(131, 285);
            this.Lb_NomCat.Name = "Lb_NomCat";
            this.Lb_NomCat.Size = new System.Drawing.Size(133, 24);
            this.Lb_NomCat.TabIndex = 10;
            this.Lb_NomCat.Text = "AnonymOUSS";
            // 
            // Lb_Nom
            // 
            this.Lb_Nom.AutoSize = true;
            this.Lb_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Nom.Location = new System.Drawing.Point(96, 71);
            this.Lb_Nom.Name = "Lb_Nom";
            this.Lb_Nom.Size = new System.Drawing.Size(207, 24);
            this.Lb_Nom.TabIndex = 11;
            this.Lb_Nom.Text = "Tour De Joueur JJJJJN";
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(415, 496);
            this.Controls.Add(this.Lb_Nom);
            this.Controls.Add(this.Lb_NomCat);
            this.Controls.Add(this.Pn_Color);
            this.Controls.Add(this.Btn_Spin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jeu";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Btn_Spin;
      private System.Windows.Forms.Panel Pn_Color;
      private System.Windows.Forms.Label Lb_NomCat;
      private System.Windows.Forms.Label Lb_Nom;

   }
}