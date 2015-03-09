namespace Tp02BaseDonnees
{
   partial class RepondreForm
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
         this.Btn_A = new System.Windows.Forms.Button();
         this.Btn_B = new System.Windows.Forms.Button();
         this.Btn_C = new System.Windows.Forms.Button();
         this.Btn_D = new System.Windows.Forms.Button();
         this.Lb_Question = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Btn_A
         // 
         this.Btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_A.Location = new System.Drawing.Point(75, 154);
         this.Btn_A.Name = "Btn_A";
         this.Btn_A.Size = new System.Drawing.Size(167, 37);
         this.Btn_A.TabIndex = 10;
         this.Btn_A.Text = "Reponse A";
         this.Btn_A.UseVisualStyleBackColor = true;
         // 
         // Btn_B
         // 
         this.Btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_B.Location = new System.Drawing.Point(75, 206);
         this.Btn_B.Name = "Btn_B";
         this.Btn_B.Size = new System.Drawing.Size(167, 37);
         this.Btn_B.TabIndex = 11;
         this.Btn_B.Text = "Reponse B";
         this.Btn_B.UseVisualStyleBackColor = true;
         // 
         // Btn_C
         // 
         this.Btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_C.Location = new System.Drawing.Point(75, 260);
         this.Btn_C.Name = "Btn_C";
         this.Btn_C.Size = new System.Drawing.Size(167, 37);
         this.Btn_C.TabIndex = 12;
         this.Btn_C.Text = "Reponse C";
         this.Btn_C.UseVisualStyleBackColor = true;
         // 
         // Btn_D
         // 
         this.Btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_D.Location = new System.Drawing.Point(75, 317);
         this.Btn_D.Name = "Btn_D";
         this.Btn_D.Size = new System.Drawing.Size(167, 37);
         this.Btn_D.TabIndex = 13;
         this.Btn_D.Text = "Reponse D";
         this.Btn_D.UseVisualStyleBackColor = true;
         // 
         // Lb_Question
         // 
         this.Lb_Question.AutoSize = true;
         this.Lb_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Lb_Question.Location = new System.Drawing.Point(68, 70);
         this.Lb_Question.Name = "Lb_Question";
         this.Lb_Question.Size = new System.Drawing.Size(174, 16);
         this.Lb_Question.TabIndex = 14;
         this.Lb_Question.Text = "La Question Les Amigossss";
         // 
         // RepondreForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(325, 419);
         this.Controls.Add(this.Lb_Question);
         this.Controls.Add(this.Btn_D);
         this.Controls.Add(this.Btn_C);
         this.Controls.Add(this.Btn_B);
         this.Controls.Add(this.Btn_A);
         this.Name = "RepondreForm";
         this.Text = "RepondreForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Btn_A;
      private System.Windows.Forms.Button Btn_B;
      private System.Windows.Forms.Button Btn_C;
      private System.Windows.Forms.Button Btn_D;
      private System.Windows.Forms.Label Lb_Question;
   }
}