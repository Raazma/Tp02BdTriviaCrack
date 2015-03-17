namespace Tp02BaseDonnees
{
    partial class ChooseCategorie
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
            this.Lb_titre = new System.Windows.Forms.Label();
            this.Btn_red = new System.Windows.Forms.Button();
            this.Btn_Orange = new System.Windows.Forms.Button();
            this.Btn_Yellow = new System.Windows.Forms.Button();
            this.Btn_Pink = new System.Windows.Forms.Button();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.Btn_Bleu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_titre
            // 
            this.Lb_titre.AutoSize = true;
            this.Lb_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_titre.Location = new System.Drawing.Point(93, 26);
            this.Lb_titre.Name = "Lb_titre";
            this.Lb_titre.Size = new System.Drawing.Size(213, 25);
            this.Lb_titre.TabIndex = 6;
            this.Lb_titre.Text = "Choisi une Categorie";
            // 
            // Btn_red
            // 
            this.Btn_red.BackColor = System.Drawing.Color.Red;
            this.Btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_red.Location = new System.Drawing.Point(278, 106);
            this.Btn_red.Name = "Btn_red";
            this.Btn_red.Size = new System.Drawing.Size(48, 23);
            this.Btn_red.TabIndex = 7;
            this.Btn_red.Text = "Art";
            this.Btn_red.UseVisualStyleBackColor = false;
            this.Btn_red.Click += new System.EventHandler(this.Btn_red_Click);
            // 
            // Btn_Orange
            // 
            this.Btn_Orange.BackColor = System.Drawing.Color.Orange;
            this.Btn_Orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Orange.Location = new System.Drawing.Point(207, 106);
            this.Btn_Orange.Name = "Btn_Orange";
            this.Btn_Orange.Size = new System.Drawing.Size(48, 23);
            this.Btn_Orange.TabIndex = 8;
            this.Btn_Orange.Text = "Spt";
            this.Btn_Orange.UseVisualStyleBackColor = false;
            this.Btn_Orange.Click += new System.EventHandler(this.Btn_Orange_Click);
            // 
            // Btn_Yellow
            // 
            this.Btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Btn_Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Yellow.Location = new System.Drawing.Point(142, 106);
            this.Btn_Yellow.Name = "Btn_Yellow";
            this.Btn_Yellow.Size = new System.Drawing.Size(48, 23);
            this.Btn_Yellow.TabIndex = 9;
            this.Btn_Yellow.Text = "His";
            this.Btn_Yellow.UseVisualStyleBackColor = false;
            this.Btn_Yellow.Click += new System.EventHandler(this.Btn_Yellow_Click);
            // 
            // Btn_Pink
            // 
            this.Btn_Pink.BackColor = System.Drawing.Color.Pink;
            this.Btn_Pink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pink.Location = new System.Drawing.Point(339, 106);
            this.Btn_Pink.Name = "Btn_Pink";
            this.Btn_Pink.Size = new System.Drawing.Size(48, 23);
            this.Btn_Pink.TabIndex = 10;
            this.Btn_Pink.Text = "Div";
            this.Btn_Pink.UseVisualStyleBackColor = false;
            this.Btn_Pink.Click += new System.EventHandler(this.Btn_Pink_Click);
            // 
            // Btn_Green
            // 
            this.Btn_Green.BackColor = System.Drawing.Color.Green;
            this.Btn_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Green.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn_Green.Location = new System.Drawing.Point(71, 106);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(48, 23);
            this.Btn_Green.TabIndex = 11;
            this.Btn_Green.Text = "Sci";
            this.Btn_Green.UseVisualStyleBackColor = false;
            this.Btn_Green.Click += new System.EventHandler(this.Btn_Green_Click);
            // 
            // Btn_Bleu
            // 
            this.Btn_Bleu.BackColor = System.Drawing.Color.Blue;
            this.Btn_Bleu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Bleu.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Bleu.Location = new System.Drawing.Point(6, 106);
            this.Btn_Bleu.Name = "Btn_Bleu";
            this.Btn_Bleu.Size = new System.Drawing.Size(48, 23);
            this.Btn_Bleu.TabIndex = 12;
            this.Btn_Bleu.Text = "Geo";
            this.Btn_Bleu.UseVisualStyleBackColor = false;
            this.Btn_Bleu.Click += new System.EventHandler(this.Btn_Bleu_Click);
            // 
            // ChooseCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 182);
            this.Controls.Add(this.Btn_Bleu);
            this.Controls.Add(this.Btn_Green);
            this.Controls.Add(this.Btn_Pink);
            this.Controls.Add(this.Btn_Yellow);
            this.Controls.Add(this.Btn_Orange);
            this.Controls.Add(this.Btn_red);
            this.Controls.Add(this.Lb_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseCategorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_titre;
        private System.Windows.Forms.Button Btn_red;
        private System.Windows.Forms.Button Btn_Orange;
        private System.Windows.Forms.Button Btn_Yellow;
        private System.Windows.Forms.Button Btn_Pink;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.Button Btn_Bleu;
    }
}