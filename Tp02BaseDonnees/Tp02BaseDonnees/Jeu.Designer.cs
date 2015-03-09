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
         this.panel1 = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
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
         // 
         // panel1
         // 
         this.panel1.Location = new System.Drawing.Point(103, 140);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(200, 100);
         this.panel1.TabIndex = 9;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(131, 285);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(133, 24);
         this.label1.TabIndex = 10;
         this.label1.Text = "AnonymOUSS";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(99, 67);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(207, 24);
         this.label2.TabIndex = 11;
         this.label2.Text = "Tour De Joueur JJJJJN";
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(415, 496);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.Btn_Spin);
         this.Name = "Jeu";
         this.Text = "Jeu";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button Btn_Spin;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;

   }
}