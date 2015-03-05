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
         this.SuspendLayout();
         // 
         // Btn_Solo
         // 
         this.Btn_Solo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Solo.Location = new System.Drawing.Point(43, 56);
         this.Btn_Solo.Name = "Btn_Solo";
         this.Btn_Solo.Size = new System.Drawing.Size(159, 23);
         this.Btn_Solo.TabIndex = 5;
         this.Btn_Solo.Text = "button1";
         this.Btn_Solo.UseVisualStyleBackColor = true;
         // 
         // Btn_Two
         // 
         this.Btn_Two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Two.Location = new System.Drawing.Point(43, 118);
         this.Btn_Two.Name = "Btn_Two";
         this.Btn_Two.Size = new System.Drawing.Size(159, 23);
         this.Btn_Two.TabIndex = 6;
         this.Btn_Two.Text = "button2";
         this.Btn_Two.UseVisualStyleBackColor = true;
         // 
         // Btn_Tree
         // 
         this.Btn_Tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Tree.Location = new System.Drawing.Point(43, 184);
         this.Btn_Tree.Name = "Btn_Tree";
         this.Btn_Tree.Size = new System.Drawing.Size(159, 23);
         this.Btn_Tree.TabIndex = 7;
         this.Btn_Tree.Text = "button3";
         this.Btn_Tree.UseVisualStyleBackColor = true;
         // 
         // Btn_Four
         // 
         this.Btn_Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Four.Location = new System.Drawing.Point(43, 244);
         this.Btn_Four.Name = "Btn_Four";
         this.Btn_Four.Size = new System.Drawing.Size(159, 23);
         this.Btn_Four.TabIndex = 8;
         this.Btn_Four.Text = "button4";
         this.Btn_Four.UseVisualStyleBackColor = true;
         // 
         // Btn_Question
         // 
         this.Btn_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Question.Location = new System.Drawing.Point(43, 320);
         this.Btn_Question.Name = "Btn_Question";
         this.Btn_Question.Size = new System.Drawing.Size(159, 23);
         this.Btn_Question.TabIndex = 9;
         this.Btn_Question.Text = "button5";
         this.Btn_Question.UseVisualStyleBackColor = true;
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(253, 414);
         this.Controls.Add(this.Btn_Question);
         this.Controls.Add(this.Btn_Four);
         this.Controls.Add(this.Btn_Tree);
         this.Controls.Add(this.Btn_Two);
         this.Controls.Add(this.Btn_Solo);
         this.Name = "Menu";
         this.Text = "Menu";
         this.Load += new System.EventHandler(this.Menu_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button Btn_Solo;
      private System.Windows.Forms.Button Btn_Two;
      private System.Windows.Forms.Button Btn_Tree;
      private System.Windows.Forms.Button Btn_Four;
      private System.Windows.Forms.Button Btn_Question;
   }
}