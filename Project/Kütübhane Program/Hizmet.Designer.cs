
namespace Kütübhane_Program
{
    partial class Hizmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hizmet));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panhiz = new System.Windows.Forms.Panel();
            this.labtanış = new System.Windows.Forms.Label();
            this.labşlık = new System.Windows.Forms.Label();
            this.btındon = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panhiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panhiz
            // 
            this.panhiz.BackgroundImage = global::Kütübhane_Program.Properties.Resources.hizmet;
            this.panhiz.Controls.Add(this.labtanış);
            this.panhiz.Controls.Add(this.labşlık);
            this.panhiz.Controls.Add(this.btındon);
            this.panhiz.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panhiz.Location = new System.Drawing.Point(0, 0);
            this.panhiz.Name = "panhiz";
            this.panhiz.Size = new System.Drawing.Size(1100, 600);
            this.panhiz.TabIndex = 0;
            // 
            // labtanış
            // 
            this.labtanış.AutoSize = true;
            this.labtanış.BackColor = System.Drawing.Color.Transparent;
            this.labtanış.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtanış.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            this.labtanış.Location = new System.Drawing.Point(396, 172);
            this.labtanış.Name = "labtanış";
            this.labtanış.Size = new System.Drawing.Size(486, 196);
            this.labtanış.TabIndex = 12;
            this.labtanış.Text = resources.GetString("labtanış.Text");
            // 
            // labşlık
            // 
            this.labşlık.AutoSize = true;
            this.labşlık.BackColor = System.Drawing.Color.Transparent;
            this.labşlık.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labşlık.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(109)))), ((int)(((byte)(60)))));
            this.labşlık.Location = new System.Drawing.Point(496, 110);
            this.labşlık.Name = "labşlık";
            this.labşlık.Size = new System.Drawing.Size(192, 25);
            this.labşlık.TabIndex = 11;
            this.labşlık.Text = "Diriliş Kütüphane";
            // 
            // btındon
            // 
            this.btındon.AllowAnimations = true;
            this.btındon.AllowMouseEffects = true;
            this.btındon.AllowToggling = false;
            this.btındon.AnimationSpeed = 200;
            this.btındon.AutoGenerateColors = false;
            this.btındon.AutoRoundBorders = true;
            this.btındon.AutoSizeLeftIcon = true;
            this.btındon.AutoSizeRightIcon = true;
            this.btındon.BackColor = System.Drawing.Color.Transparent;
            this.btındon.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btındon.BackgroundImage")));
            this.btındon.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btındon.ButtonText = "Ana Sayfaya Geri Dön";
            this.btındon.ButtonTextMarginLeft = 0;
            this.btındon.ColorContrastOnClick = 45;
            this.btındon.ColorContrastOnHover = 45;
            this.btındon.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btındon.CustomizableEdges = borderEdges2;
            this.btındon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btındon.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btındon.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btındon.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btındon.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btındon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btındon.ForeColor = System.Drawing.Color.White;
            this.btındon.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btındon.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btındon.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btındon.IconMarginLeft = 11;
            this.btındon.IconPadding = 10;
            this.btındon.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btındon.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btındon.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btındon.IconSize = 25;
            this.btındon.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.IdleBorderRadius = 27;
            this.btındon.IdleBorderThickness = 1;
            this.btındon.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.IdleIconLeftImage = null;
            this.btındon.IdleIconRightImage = null;
            this.btındon.IndicateFocus = false;
            this.btındon.Location = new System.Drawing.Point(728, 460);
            this.btındon.Name = "btındon";
            this.btındon.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btındon.OnDisabledState.BorderRadius = 1;
            this.btındon.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btındon.OnDisabledState.BorderThickness = 1;
            this.btındon.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btındon.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btındon.OnDisabledState.IconLeftImage = null;
            this.btındon.OnDisabledState.IconRightImage = null;
            this.btındon.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btındon.onHoverState.BorderRadius = 1;
            this.btındon.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btındon.onHoverState.BorderThickness = 1;
            this.btındon.onHoverState.FillColor = System.Drawing.Color.White;
            this.btındon.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.onHoverState.IconLeftImage = null;
            this.btındon.onHoverState.IconRightImage = null;
            this.btındon.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.OnIdleState.BorderRadius = 1;
            this.btındon.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btındon.OnIdleState.BorderThickness = 1;
            this.btındon.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btındon.OnIdleState.IconLeftImage = null;
            this.btındon.OnIdleState.IconRightImage = null;
            this.btındon.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.OnPressedState.BorderRadius = 1;
            this.btındon.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btındon.OnPressedState.BorderThickness = 1;
            this.btındon.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(109)))), ((int)(((byte)(43)))));
            this.btındon.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btındon.OnPressedState.IconLeftImage = null;
            this.btındon.OnPressedState.IconRightImage = null;
            this.btındon.Size = new System.Drawing.Size(151, 29);
            this.btındon.TabIndex = 10;
            this.btındon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btındon.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btındon.TextMarginLeft = 0;
            this.btındon.TextPadding = new System.Windows.Forms.Padding(0);
            this.btındon.UseDefaultRadiusAndThickness = true;
            this.btındon.Click += new System.EventHandler(this.btındon_Click);
            // 
            // Hizmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panhiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hizmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmet";
            this.panhiz.ResumeLayout(false);
            this.panhiz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panhiz;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btındon;
        private System.Windows.Forms.Label labşlık;
        private System.Windows.Forms.Label labtanış;
    }
}