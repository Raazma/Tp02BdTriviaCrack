namespace Tp02BaseDonnees
{
   partial class FormAjoutQuestion
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            this.Cb_Categories = new System.Windows.Forms.ComboBox();
            this.Tb_Question = new System.Windows.Forms.TextBox();
            this.Tb_A = new System.Windows.Forms.TextBox();
            this.Tb_C = new System.Windows.Forms.TextBox();
            this.Tb_D = new System.Windows.Forms.TextBox();
            this.Tb_B = new System.Windows.Forms.TextBox();
            this.Cb_Rep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cb_Categories
            // 
            this.Cb_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Categories.FormattingEnabled = true;
            this.Cb_Categories.Items.AddRange(new object[] {
            "Geographie",
            "Science",
            "Histoire",
            "Sport",
            "Art",
            "Divertissement"});
            this.Cb_Categories.Location = new System.Drawing.Point(81, 32);
            this.Cb_Categories.Name = "Cb_Categories";
            this.Cb_Categories.Size = new System.Drawing.Size(140, 21);
            this.Cb_Categories.TabIndex = 0;
            // 
            // Tb_Question
            // 
            this.Tb_Question.Location = new System.Drawing.Point(86, 87);
            this.Tb_Question.Multiline = true;
            this.Tb_Question.Name = "Tb_Question";
            this.Tb_Question.Size = new System.Drawing.Size(191, 56);
            this.Tb_Question.TabIndex = 1;
            // 
            // Tb_A
            // 
            this.Tb_A.Location = new System.Drawing.Point(53, 25);
            this.Tb_A.Name = "Tb_A";
            this.Tb_A.Size = new System.Drawing.Size(100, 20);
            this.Tb_A.TabIndex = 2;
            // 
            // Tb_C
            // 
            this.Tb_C.Location = new System.Drawing.Point(53, 69);
            this.Tb_C.Name = "Tb_C";
            this.Tb_C.Size = new System.Drawing.Size(100, 20);
            this.Tb_C.TabIndex = 4;
            // 
            // Tb_D
            // 
            this.Tb_D.Location = new System.Drawing.Point(213, 69);
            this.Tb_D.Name = "Tb_D";
            this.Tb_D.Size = new System.Drawing.Size(100, 20);
            this.Tb_D.TabIndex = 5;
            // 
            // Tb_B
            // 
            this.Tb_B.Location = new System.Drawing.Point(213, 25);
            this.Tb_B.Name = "Tb_B";
            this.Tb_B.Size = new System.Drawing.Size(100, 20);
            this.Tb_B.TabIndex = 6;
            // 
            // Cb_Rep
            // 
            this.Cb_Rep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Rep.FormattingEnabled = true;
            this.Cb_Rep.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Cb_Rep.Location = new System.Drawing.Point(23, 331);
            this.Cb_Rep.Name = "Cb_Rep";
            this.Cb_Rep.Size = new System.Drawing.Size(41, 21);
            this.Cb_Rep.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Catégorie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "La Question:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "La Reponse";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tb_A);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tb_C);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Tb_D);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tb_B);
            this.groupBox1.Location = new System.Drawing.Point(14, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de Réponse";
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.Location = new System.Drawing.Point(131, 369);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Enregistrer.TabIndex = 16;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(227, 369);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 17;
            this.Btn_Cancel.Text = "Annuler";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 409);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Rep);
            this.Controls.Add(this.Tb_Question);
            this.Controls.Add(this.Cb_Categories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox Cb_Categories;
      private System.Windows.Forms.TextBox Tb_Question;
      private System.Windows.Forms.TextBox Tb_A;
      private System.Windows.Forms.TextBox Tb_C;
      private System.Windows.Forms.TextBox Tb_D;
      private System.Windows.Forms.TextBox Tb_B;
      private System.Windows.Forms.ComboBox Cb_Rep;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button Btn_Enregistrer;
      private System.Windows.Forms.Button Btn_Cancel;
   }
}

