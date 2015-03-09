namespace Tp02BaseDonnees
{
   partial class CompteExistant
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
         this.Lb_Alias = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.Btn_Validation = new System.Windows.Forms.Button();
         this.Btn_Annuler = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Lb_Alias
         // 
         this.Lb_Alias.AutoSize = true;
         this.Lb_Alias.Location = new System.Drawing.Point(34, 55);
         this.Lb_Alias.Name = "Lb_Alias";
         this.Lb_Alias.Size = new System.Drawing.Size(88, 13);
         this.Lb_Alias.TabIndex = 0;
         this.Lb_Alias.Text = "ALias Du compte";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(128, 52);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(129, 20);
         this.textBox1.TabIndex = 1;
         // 
         // Btn_Validation
         // 
         this.Btn_Validation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Validation.Location = new System.Drawing.Point(128, 93);
         this.Btn_Validation.Name = "Btn_Validation";
         this.Btn_Validation.Size = new System.Drawing.Size(129, 23);
         this.Btn_Validation.TabIndex = 8;
         this.Btn_Validation.Text = "Connection";
         this.Btn_Validation.UseVisualStyleBackColor = true;
         // 
         // Btn_Annuler
         // 
         this.Btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Annuler.Location = new System.Drawing.Point(126, 122);
         this.Btn_Annuler.Name = "Btn_Annuler";
         this.Btn_Annuler.Size = new System.Drawing.Size(131, 23);
         this.Btn_Annuler.TabIndex = 9;
         this.Btn_Annuler.Text = "Annuler";
         this.Btn_Annuler.UseVisualStyleBackColor = true;
         // 
         // CompteExistant
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(303, 194);
         this.Controls.Add(this.Btn_Annuler);
         this.Controls.Add(this.Btn_Validation);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.Lb_Alias);
         this.Name = "CompteExistant";
         this.Text = "CompteExistant";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Lb_Alias;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button Btn_Validation;
      private System.Windows.Forms.Button Btn_Annuler;
   }
}