namespace Tp02BaseDonnees
{
    partial class StartGame
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
            this.Btn_Jouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Jouer
            // 
            this.Btn_Jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Jouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Jouer.Location = new System.Drawing.Point(37, 62);
            this.Btn_Jouer.Name = "Btn_Jouer";
            this.Btn_Jouer.Size = new System.Drawing.Size(210, 137);
            this.Btn_Jouer.TabIndex = 0;
            this.Btn_Jouer.Text = "Jouer";
            this.Btn_Jouer.UseVisualStyleBackColor = true;
            this.Btn_Jouer.Click += new System.EventHandler(this.Btn_Jouer_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn_Jouer);
            this.Name = "StartGame";
            this.Text = "StartGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Jouer;
    }
}