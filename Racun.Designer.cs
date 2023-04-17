namespace ORAKL_NIOP
{
    partial class Racun
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
            this.buttonSlanje = new System.Windows.Forms.Button();
            this.buttonDodajArtikl = new System.Windows.Forms.Button();
            this.buttonMakniArtikl = new System.Windows.Forms.Button();
            this.buttonNatrag = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSlanje
            // 
            this.buttonSlanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSlanje.Location = new System.Drawing.Point(1649, 0);
            this.buttonSlanje.Name = "buttonSlanje";
            this.buttonSlanje.Size = new System.Drawing.Size(256, 132);
            this.buttonSlanje.TabIndex = 0;
            this.buttonSlanje.Text = "SLANJE";
            this.buttonSlanje.UseVisualStyleBackColor = true;
            // 
            // buttonDodajArtikl
            // 
            this.buttonDodajArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajArtikl.Location = new System.Drawing.Point(1396, 0);
            this.buttonDodajArtikl.Name = "buttonDodajArtikl";
            this.buttonDodajArtikl.Size = new System.Drawing.Size(256, 132);
            this.buttonDodajArtikl.TabIndex = 1;
            this.buttonDodajArtikl.Text = "+1";
            this.buttonDodajArtikl.UseVisualStyleBackColor = true;
            this.buttonDodajArtikl.Click += new System.EventHandler(this.buttonDodajArtikl_Click);
            // 
            // buttonMakniArtikl
            // 
            this.buttonMakniArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMakniArtikl.Location = new System.Drawing.Point(1143, 0);
            this.buttonMakniArtikl.Name = "buttonMakniArtikl";
            this.buttonMakniArtikl.Size = new System.Drawing.Size(256, 132);
            this.buttonMakniArtikl.TabIndex = 2;
            this.buttonMakniArtikl.Text = "-1";
            this.buttonMakniArtikl.UseVisualStyleBackColor = true;
            // 
            // buttonNatrag
            // 
            this.buttonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNatrag.Location = new System.Drawing.Point(0, 0);
            this.buttonNatrag.Name = "buttonNatrag";
            this.buttonNatrag.Size = new System.Drawing.Size(256, 132);
            this.buttonNatrag.TabIndex = 3;
            this.buttonNatrag.Text = "IZLAZ";
            this.buttonNatrag.UseVisualStyleBackColor = true;
            this.buttonNatrag.Click += new System.EventHandler(this.buttonNatrag_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(134, 217);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(706, 635);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(134, 926);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(445, 38);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnesi.Location = new System.Drawing.Point(656, 879);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(184, 85);
            this.buttonUnesi.TabIndex = 6;
            this.buttonUnesi.Text = "UNESI";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(1396, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 44);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNatrag);
            this.Controls.Add(this.buttonMakniArtikl);
            this.Controls.Add(this.buttonDodajArtikl);
            this.Controls.Add(this.buttonSlanje);
            this.Name = "Racun";
            this.Text = "Racun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Racun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSlanje;
        private System.Windows.Forms.Button buttonDodajArtikl;
        private System.Windows.Forms.Button buttonMakniArtikl;
        private System.Windows.Forms.Button buttonNatrag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.TextBox textBox3;
    }
}