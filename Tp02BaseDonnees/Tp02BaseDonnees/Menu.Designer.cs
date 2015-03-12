namespace Tp02BaseDonnees
{
   partial class Menu
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
         this.Btn_Solo = new System.Windows.Forms.Button();
         this.Btn_Two = new System.Windows.Forms.Button();
         this.Btn_Tree = new System.Windows.Forms.Button();
         this.Btn_Four = new System.Windows.Forms.Button();
         this.Btn_Question = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.Btn_Quitter = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Btn_Solo
         // 
         this.Btn_Solo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Solo.Location = new System.Drawing.Point(43, 106);
         this.Btn_Solo.Name = "Btn_Solo";
         this.Btn_Solo.Size = new System.Drawing.Size(159, 23);
         this.Btn_Solo.TabIndex = 5;
         this.Btn_Solo.Text = "Solo Joueur";
         this.Btn_Solo.UseVisualStyleBackColor = true;
         this.Btn_Solo.Click += new System.EventHandler(this.Btn_Solo_Click);
         // 
         // Btn_Two
         // 
         this.Btn_Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Two.Location = new System.Drawing.Point(43, 168);
         this.Btn_Two.Name = "Btn_Two";
         this.Btn_Two.Size = new System.Drawing.Size(159, 23);
         this.Btn_Two.TabIndex = 6;
         this.Btn_Two.Text = "2 Joueurs";
         this.Btn_Two.UseVisualStyleBackColor = true;
         this.Btn_Two.Click += new System.EventHandler(this.Btn_Two_Click);
         // 
         // Btn_Tree
         // 
         this.Btn_Tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Tree.Location = new System.Drawing.Point(43, 234);
         this.Btn_Tree.Name = "Btn_Tree";
         this.Btn_Tree.Size = new System.Drawing.Size(159, 23);
         this.Btn_Tree.TabIndex = 7;
         this.Btn_Tree.Text = "3 Joueurs";
         this.Btn_Tree.UseVisualStyleBackColor = true;
         this.Btn_Tree.Click += new System.EventHandler(this.Btn_Tree_Click);
         // 
         // Btn_Four
         // 
         this.Btn_Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Four.Location = new System.Drawing.Point(43, 294);
         this.Btn_Four.Name = "Btn_Four";
         this.Btn_Four.Size = new System.Drawing.Size(159, 23);
         this.Btn_Four.TabIndex = 8;
         this.Btn_Four.Text = "4 Joueurs";
         this.Btn_Four.UseVisualStyleBackColor = true;
         this.Btn_Four.Click += new System.EventHandler(this.Btn_Four_Click);
         // 
         // Btn_Question
         // 
         this.Btn_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Question.Location = new System.Drawing.Point(43, 357);
         this.Btn_Question.Name = "Btn_Question";
         this.Btn_Question.Size = new System.Drawing.Size(159, 23);
         this.Btn_Question.TabIndex = 9;
         this.Btn_Question.Text = "Ajout Questions";
         this.Btn_Question.UseVisualStyleBackColor = true;
         this.Btn_Question.Click += new System.EventHandler(this.Btn_Question_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(81, 33);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(66, 25);
         this.label1.TabIndex = 10;
         this.label1.Text = "Menu";
         // 
         // Btn_Quitter
         // 
         this.Btn_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Quitter.Location = new System.Drawing.Point(43, 416);
         this.Btn_Quitter.Name = "Btn_Quitter";
         this.Btn_Quitter.Size = new System.Drawing.Size(159, 23);
         this.Btn_Quitter.TabIndex = 11;
         this.Btn_Quitter.Text = "Quitter";
         this.Btn_Quitter.UseVisualStyleBackColor = true;
         this.Btn_Quitter.Click += new System.EventHandler(this.Btn_Quitter_Click);
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(253, 476);
         this.Controls.Add(this.Btn_Quitter);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Btn_Question);
         this.Controls.Add(this.Btn_Four);
         this.Controls.Add(this.Btn_Tree);
         this.Controls.Add(this.Btn_Two);
         this.Controls.Add(this.Btn_Solo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "Menu";
         this.Load += new System.EventHandler(this.Menu_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Btn_Solo;
      private System.Windows.Forms.Button Btn_Two;
      private System.Windows.Forms.Button Btn_Tree;
      private System.Windows.Forms.Button Btn_Four;
      private System.Windows.Forms.Button Btn_Question;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button Btn_Quitter;
   }
}