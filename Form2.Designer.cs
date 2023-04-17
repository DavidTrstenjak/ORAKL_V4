namespace ORAKL_NIOP
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOtvSmj = new System.Windows.Forms.Button();
            this.buttonRacun = new System.Windows.Forms.Button();
            this.buttonZtvSmj = new System.Windows.Forms.Button();
            this.buttonIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izlaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOtvSmj
            // 
            this.buttonOtvSmj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtvSmj.Location = new System.Drawing.Point(724, 281);
            this.buttonOtvSmj.Name = "buttonOtvSmj";
            this.buttonOtvSmj.Size = new System.Drawing.Size(399, 78);
            this.buttonOtvSmj.TabIndex = 1;
            this.buttonOtvSmj.Text = "Otvaranje smjene";
            this.buttonOtvSmj.UseVisualStyleBackColor = true;
            this.buttonOtvSmj.Click += new System.EventHandler(this.buttonOtvSmj_Click);
            // 
            // buttonRacun
            // 
            this.buttonRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRacun.Location = new System.Drawing.Point(724, 394);
            this.buttonRacun.Name = "buttonRacun";
            this.buttonRacun.Size = new System.Drawing.Size(399, 78);
            this.buttonRacun.TabIndex = 2;
            this.buttonRacun.Text = "Račun";
            this.buttonRacun.UseVisualStyleBackColor = true;
            this.buttonRacun.Click += new System.EventHandler(this.buttonRacun_Click);
            // 
            // buttonZtvSmj
            // 
            this.buttonZtvSmj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZtvSmj.Location = new System.Drawing.Point(724, 506);
            this.buttonZtvSmj.Name = "buttonZtvSmj";
            this.buttonZtvSmj.Size = new System.Drawing.Size(399, 78);
            this.buttonZtvSmj.TabIndex = 3;
            this.buttonZtvSmj.Text = "Zatvaranje smjene";
            this.buttonZtvSmj.UseVisualStyleBackColor = true;
            this.buttonZtvSmj.Click += new System.EventHandler(this.buttonZtvSmj_Click);
            // 
            // buttonIspis
            // 
            this.buttonIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIspis.Location = new System.Drawing.Point(724, 614);
            this.buttonIspis.Name = "buttonIspis";
            this.buttonIspis.Size = new System.Drawing.Size(399, 78);
            this.buttonIspis.TabIndex = 4;
            this.buttonIspis.Text = "Ispis";
            this.buttonIspis.UseVisualStyleBackColor = true;
            this.buttonIspis.Click += new System.EventHandler(this.buttonIspis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonIspis);
            this.Controls.Add(this.buttonZtvSmj);
            this.Controls.Add(this.buttonRacun);
            this.Controls.Add(this.buttonOtvSmj);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOtvSmj;
        private System.Windows.Forms.Button buttonRacun;
        private System.Windows.Forms.Button buttonZtvSmj;
        private System.Windows.Forms.Button buttonIspis;
    }
}