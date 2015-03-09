namespace Tp02BaseDonnees
{
   partial class FormScoreF
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.btn_NouvellePartie = new System.Windows.Forms.Button();
         this.Btn_Quitter = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.Lb_Gagant = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Location = new System.Drawing.Point(34, 153);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(631, 293);
         this.dataGridView1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(281, 107);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(150, 29);
         this.label1.TabIndex = 1;
         this.label1.Text = "Score Finale";
         // 
         // btn_NouvellePartie
         // 
         this.btn_NouvellePartie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btn_NouvellePartie.Location = new System.Drawing.Point(380, 514);
         this.btn_NouvellePartie.Name = "btn_NouvellePartie";
         this.btn_NouvellePartie.Size = new System.Drawing.Size(107, 32);
         this.btn_NouvellePartie.TabIndex = 2;
         this.btn_NouvellePartie.Text = "Nouvelle Partie";
         this.btn_NouvellePartie.UseVisualStyleBackColor = true;
         // 
         // Btn_Quitter
         // 
         this.Btn_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Quitter.Location = new System.Drawing.Point(547, 514);
         this.Btn_Quitter.Name = "Btn_Quitter";
         this.Btn_Quitter.Size = new System.Drawing.Size(118, 32);
         this.Btn_Quitter.TabIndex = 3;
         this.Btn_Quitter.Text = "Quitter";
         this.Btn_Quitter.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(67, 50);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(129, 20);
         this.label2.TabIndex = 4;
         this.label2.Text = "Joueur Gagnant:";
         // 
         // Lb_Gagant
         // 
         this.Lb_Gagant.AutoSize = true;
         this.Lb_Gagant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Lb_Gagant.Location = new System.Drawing.Point(213, 50);
         this.Lb_Gagant.Name = "Lb_Gagant";
         this.Lb_Gagant.Size = new System.Drawing.Size(117, 20);
         this.Lb_Gagant.TabIndex = 5;
         this.Lb_Gagant.Text = "Nom du Joueur";
         // 
         // FormScoreF
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(713, 593);
         this.Controls.Add(this.Lb_Gagant);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.Btn_Quitter);
         this.Controls.Add(this.btn_NouvellePartie);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView1);
         this.Name = "FormScoreF";
         this.Text = "FormScoreF";
         this.Load += new System.EventHandler(this.FormScoreF_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btn_NouvellePartie;
      private System.Windows.Forms.Button Btn_Quitter;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label Lb_Gagant;
   }
}