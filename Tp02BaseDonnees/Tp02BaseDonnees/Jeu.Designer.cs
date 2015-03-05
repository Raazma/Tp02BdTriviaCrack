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
         this.Pn_1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // Pn_1
         // 
         this.Pn_1.BackColor = System.Drawing.Color.LightGray;
         this.Pn_1.Location = new System.Drawing.Point(40, 58);
         this.Pn_1.Name = "Pn_1";
         this.Pn_1.Size = new System.Drawing.Size(305, 40);
         this.Pn_1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.LightGray;
         this.panel2.Location = new System.Drawing.Point(40, 143);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(305, 49);
         this.panel2.TabIndex = 1;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.LightGray;
         this.panel3.Location = new System.Drawing.Point(40, 233);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(305, 51);
         this.panel3.TabIndex = 2;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.LightGray;
         this.panel1.Location = new System.Drawing.Point(40, 327);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(305, 51);
         this.panel1.TabIndex = 3;
         // 
         // Jeu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gray;
         this.ClientSize = new System.Drawing.Size(415, 592);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.Pn_1);
         this.Name = "Jeu";
         this.Text = "Jeu";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel Pn_1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Panel panel1;
   }
}