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
            this.Tb_Alias = new System.Windows.Forms.TextBox();
            this.Btn_Validation = new System.Windows.Forms.Button();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Alias
            // 
            this.Lb_Alias.AutoSize = true;
            this.Lb_Alias.Location = new System.Drawing.Point(45, 68);
            this.Lb_Alias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Alias.Name = "Lb_Alias";
            this.Lb_Alias.Size = new System.Drawing.Size(115, 17);
            this.Lb_Alias.TabIndex = 0;
            this.Lb_Alias.Text = "ALias Du compte";
            // 
            // Tb_Alias
            // 
            this.Tb_Alias.Location = new System.Drawing.Point(171, 64);
            this.Tb_Alias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tb_Alias.Name = "Tb_Alias";
            this.Tb_Alias.Size = new System.Drawing.Size(171, 22);
            this.Tb_Alias.TabIndex = 1;
            this.Tb_Alias.TextChanged += new System.EventHandler(this.Tb_Alias_TextChanged);
            // 
            // Btn_Validation
            // 
            this.Btn_Validation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Validation.Location = new System.Drawing.Point(171, 114);
            this.Btn_Validation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Validation.Name = "Btn_Validation";
            this.Btn_Validation.Size = new System.Drawing.Size(172, 28);
            this.Btn_Validation.TabIndex = 8;
            this.Btn_Validation.Text = "Connection";
            this.Btn_Validation.UseVisualStyleBackColor = true;
            this.Btn_Validation.Click += new System.EventHandler(this.Btn_Validation_Click);
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Annuler.Location = new System.Drawing.Point(168, 150);
            this.Btn_Annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(175, 28);
            this.Btn_Annuler.TabIndex = 9;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // CompteExistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 239);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Btn_Validation);
            this.Controls.Add(this.Tb_Alias);
            this.Controls.Add(this.Lb_Alias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CompteExistant";
            this.Text = "CompteExistant";
            this.Load += new System.EventHandler(this.CompteExistant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label Lb_Alias;
      private System.Windows.Forms.TextBox Tb_Alias;
      private System.Windows.Forms.Button Btn_Validation;
      private System.Windows.Forms.Button Btn_Annuler;
   }
}