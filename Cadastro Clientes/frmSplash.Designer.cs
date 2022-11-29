
namespace Cadastro_Clientes
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDev1 = new System.Windows.Forms.Label();
            this.lblDev2 = new System.Windows.Forms.Label();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(174, 74);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Loja Sotovie";
            // 
            // lblDev1
            // 
            this.lblDev1.AutoSize = true;
            this.lblDev1.BackColor = System.Drawing.Color.Transparent;
            this.lblDev1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev1.ForeColor = System.Drawing.Color.White;
            this.lblDev1.Location = new System.Drawing.Point(180, 201);
            this.lblDev1.Name = "lblDev1";
            this.lblDev1.Size = new System.Drawing.Size(287, 19);
            this.lblDev1.TabIndex = 1;
            this.lblDev1.Text = "13 - Italo Carlos Martins Bresciani";
            // 
            // lblDev2
            // 
            this.lblDev2.AutoSize = true;
            this.lblDev2.BackColor = System.Drawing.Color.Transparent;
            this.lblDev2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev2.ForeColor = System.Drawing.Color.White;
            this.lblDev2.Location = new System.Drawing.Point(180, 261);
            this.lblDev2.Name = "lblDev2";
            this.lblDev2.Size = new System.Drawing.Size(208, 19);
            this.lblDev2.TabIndex = 2;
            this.lblDev2.Text = " 18 - Laura Lima Denardi";
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 5000;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = " 26 - Nathan Braian Mariano Anunciação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = " 34 - Ulisses Rodrigues Barreto";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDev2);
            this.Controls.Add(this.lblDev1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDev1;
        private System.Windows.Forms.Label lblDev2;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}