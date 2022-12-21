
namespace Kütübhane_Program
{
    partial class liste
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
            this.btnAna = new System.Windows.Forms.Button();
            this.btnKitap = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAna
            // 
            this.btnAna.BackgroundImage = global::Kütübhane_Program.Properties.Resources.back2;
            this.btnAna.ForeColor = System.Drawing.Color.White;
            this.btnAna.Location = new System.Drawing.Point(172, 147);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(217, 47);
            this.btnAna.TabIndex = 0;
            this.btnAna.Text = "Ana Sayfa";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnKitap
            // 
            this.btnKitap.BackgroundImage = global::Kütübhane_Program.Properties.Resources.back;
            this.btnKitap.ForeColor = System.Drawing.Color.White;
            this.btnKitap.Location = new System.Drawing.Point(172, 351);
            this.btnKitap.Name = "btnKitap";
            this.btnKitap.Size = new System.Drawing.Size(217, 46);
            this.btnKitap.TabIndex = 1;
            this.btnKitap.Text = "Kitaplar";
            this.btnKitap.UseVisualStyleBackColor = true;
            this.btnKitap.Click += new System.EventHandler(this.btnKitap_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackgroundImage = global::Kütübhane_Program.Properties.Resources.back;
            this.btnCik.ForeColor = System.Drawing.Color.White;
            this.btnCik.Location = new System.Drawing.Point(172, 568);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(217, 46);
            this.btnCik.TabIndex = 6;
            this.btnCik.Text = "Çıkış";
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(609, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 710);
            this.panel1.TabIndex = 7;
            // 
            // liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kütübhane_Program.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnKitap);
            this.Controls.Add(this.btnAna);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1500, 450);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAna;
        private System.Windows.Forms.Button btnKitap;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Panel panel1;
    }
}