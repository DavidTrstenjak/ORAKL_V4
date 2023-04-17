namespace ORAKL_NIOP
{
    partial class Ispis
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBrojRacuna = new System.Windows.Forms.TextBox();
            this.btnSlanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(67, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi broj računa :";
            // 
            // textBoxBrojRacuna
            // 
            this.textBoxBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBrojRacuna.Location = new System.Drawing.Point(160, 154);
            this.textBoxBrojRacuna.Name = "textBoxBrojRacuna";
            this.textBoxBrojRacuna.Size = new System.Drawing.Size(110, 44);
            this.textBoxBrojRacuna.TabIndex = 1;
            // 
            // btnSlanje
            // 
            this.btnSlanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSlanje.Location = new System.Drawing.Point(317, 12);
            this.btnSlanje.Name = "btnSlanje";
            this.btnSlanje.Size = new System.Drawing.Size(119, 70);
            this.btnSlanje.TabIndex = 2;
            this.btnSlanje.Text = "SLANJE";
            this.btnSlanje.UseVisualStyleBackColor = true;
            // 
            // Ispis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 237);
            this.Controls.Add(this.btnSlanje);
            this.Controls.Add(this.textBoxBrojRacuna);
            this.Controls.Add(this.label1);
            this.Name = "Ispis";
            this.Text = "Ispis";
            this.Load += new System.EventHandler(this.Ispis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBrojRacuna;
        private System.Windows.Forms.Button btnSlanje;
    }
}