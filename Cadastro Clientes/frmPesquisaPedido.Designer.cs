
namespace Cadastro_Clientes
{
    partial class frmPesquisaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaPedido));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisarPedido = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblPesquisarPor = new System.Windows.Forms.Label();
            this.lblAparelho = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblValorPedido = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cmbAparelho = new System.Windows.Forms.ComboBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.chkAparelho = new System.Windows.Forms.CheckBox();
            this.chkDataPedido = new System.Windows.Forms.CheckBox();
            this.chkValorPedido = new System.Windows.Forms.CheckBox();
            this.chkFabricante = new System.Windows.Forms.CheckBox();
            this.dateDataPedido1 = new System.Windows.Forms.DateTimePicker();
            this.dateDataPedido2 = new System.Windows.Forms.DateTimePicker();
            this.lbla = new System.Windows.Forms.Label();
            this.numValorPedido1 = new System.Windows.Forms.NumericUpDown();
            this.numValorPedido2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPedido1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPedido2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(756, 517);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 31);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisarPedido
            // 
            this.btnPesquisarPedido.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPedido.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarPedido.Location = new System.Drawing.Point(620, 517);
            this.btnPesquisarPedido.Name = "btnPesquisarPedido";
            this.btnPesquisarPedido.Size = new System.Drawing.Size(101, 31);
            this.btnPesquisarPedido.TabIndex = 25;
            this.btnPesquisarPedido.Text = "&Pesquisar";
            this.btnPesquisarPedido.UseVisualStyleBackColor = true;
            this.btnPesquisarPedido.Click += new System.EventHandler(this.btnPesquisarPedido_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(295, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 31);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Pesquisa de pedidos";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPedidos.Location = new System.Drawing.Point(127, 63);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(611, 239);
            this.dgvPedidos.TabIndex = 20;
            // 
            // lblPesquisarPor
            // 
            this.lblPesquisarPor.AutoSize = true;
            this.lblPesquisarPor.BackColor = System.Drawing.Color.Transparent;
            this.lblPesquisarPor.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisarPor.Location = new System.Drawing.Point(12, 316);
            this.lblPesquisarPor.Name = "lblPesquisarPor";
            this.lblPesquisarPor.Size = new System.Drawing.Size(103, 15);
            this.lblPesquisarPor.TabIndex = 31;
            this.lblPesquisarPor.Text = "Pesquisar por:";
            // 
            // lblAparelho
            // 
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.BackColor = System.Drawing.Color.Transparent;
            this.lblAparelho.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAparelho.Location = new System.Drawing.Point(12, 360);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(75, 15);
            this.lblAparelho.TabIndex = 32;
            this.lblAparelho.Text = "Aparelho:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblDataPedido.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedido.Location = new System.Drawing.Point(12, 398);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(90, 15);
            this.lblDataPedido.TabIndex = 33;
            this.lblDataPedido.Text = "Data pedido:";
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPedido.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPedido.Location = new System.Drawing.Point(12, 444);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(98, 15);
            this.lblValorPedido.TabIndex = 34;
            this.lblValorPedido.Text = "Valor pedido:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.BackColor = System.Drawing.Color.Transparent;
            this.lblFabricante.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricante.Location = new System.Drawing.Point(12, 489);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(84, 15);
            this.lblFabricante.TabIndex = 35;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // cmbAparelho
            // 
            this.cmbAparelho.FormattingEnabled = true;
            this.cmbAparelho.Location = new System.Drawing.Point(117, 354);
            this.cmbAparelho.Name = "cmbAparelho";
            this.cmbAparelho.Size = new System.Drawing.Size(464, 21);
            this.cmbAparelho.TabIndex = 36;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(117, 483);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(464, 21);
            this.cmbFabricante.TabIndex = 37;
            // 
            // chkAparelho
            // 
            this.chkAparelho.AutoSize = true;
            this.chkAparelho.Location = new System.Drawing.Point(620, 357);
            this.chkAparelho.Name = "chkAparelho";
            this.chkAparelho.Size = new System.Drawing.Size(15, 14);
            this.chkAparelho.TabIndex = 38;
            this.chkAparelho.UseVisualStyleBackColor = true;
            this.chkAparelho.CheckedChanged += new System.EventHandler(this.chkAparelho_CheckedChanged);
            // 
            // chkDataPedido
            // 
            this.chkDataPedido.AutoSize = true;
            this.chkDataPedido.Location = new System.Drawing.Point(620, 399);
            this.chkDataPedido.Name = "chkDataPedido";
            this.chkDataPedido.Size = new System.Drawing.Size(15, 14);
            this.chkDataPedido.TabIndex = 39;
            this.chkDataPedido.UseVisualStyleBackColor = true;
            this.chkDataPedido.CheckedChanged += new System.EventHandler(this.chkDataPedido_CheckedChanged);
            // 
            // chkValorPedido
            // 
            this.chkValorPedido.AutoSize = true;
            this.chkValorPedido.Location = new System.Drawing.Point(620, 444);
            this.chkValorPedido.Name = "chkValorPedido";
            this.chkValorPedido.Size = new System.Drawing.Size(15, 14);
            this.chkValorPedido.TabIndex = 40;
            this.chkValorPedido.UseVisualStyleBackColor = true;
            this.chkValorPedido.CheckedChanged += new System.EventHandler(this.chkValorPedido_CheckedChanged);
            // 
            // chkFabricante
            // 
            this.chkFabricante.AutoSize = true;
            this.chkFabricante.Location = new System.Drawing.Point(620, 486);
            this.chkFabricante.Name = "chkFabricante";
            this.chkFabricante.Size = new System.Drawing.Size(15, 14);
            this.chkFabricante.TabIndex = 41;
            this.chkFabricante.UseVisualStyleBackColor = true;
            this.chkFabricante.CheckedChanged += new System.EventHandler(this.chkFabricante_CheckedChanged);
            // 
            // dateDataPedido1
            // 
            this.dateDataPedido1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataPedido1.Location = new System.Drawing.Point(117, 393);
            this.dateDataPedido1.Name = "dateDataPedido1";
            this.dateDataPedido1.Size = new System.Drawing.Size(200, 20);
            this.dateDataPedido1.TabIndex = 42;
            // 
            // dateDataPedido2
            // 
            this.dateDataPedido2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataPedido2.Location = new System.Drawing.Point(381, 393);
            this.dateDataPedido2.Name = "dateDataPedido2";
            this.dateDataPedido2.Size = new System.Drawing.Size(200, 20);
            this.dateDataPedido2.TabIndex = 43;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.Color.Transparent;
            this.lbla.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(337, 398);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(18, 15);
            this.lbla.TabIndex = 44;
            this.lbla.Text = "a:";
            // 
            // numValorPedido1
            // 
            this.numValorPedido1.Location = new System.Drawing.Point(117, 439);
            this.numValorPedido1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numValorPedido1.Name = "numValorPedido1";
            this.numValorPedido1.Size = new System.Drawing.Size(200, 20);
            this.numValorPedido1.TabIndex = 45;
            // 
            // numValorPedido2
            // 
            this.numValorPedido2.Location = new System.Drawing.Point(381, 439);
            this.numValorPedido2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numValorPedido2.Name = "numValorPedido2";
            this.numValorPedido2.Size = new System.Drawing.Size(200, 20);
            this.numValorPedido2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "a:";
            // 
            // frmPesquisaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 560);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numValorPedido2);
            this.Controls.Add(this.numValorPedido1);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.dateDataPedido2);
            this.Controls.Add(this.dateDataPedido1);
            this.Controls.Add(this.chkFabricante);
            this.Controls.Add(this.chkValorPedido);
            this.Controls.Add(this.chkDataPedido);
            this.Controls.Add(this.chkAparelho);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.cmbAparelho);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblValorPedido);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblAparelho);
            this.Controls.Add(this.lblPesquisarPor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisarPedido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaPedido";
            this.Load += new System.EventHandler(this.frmPesquisaPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPedido1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValorPedido2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisarPedido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblPesquisarPor;
        private System.Windows.Forms.Label lblAparelho;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblValorPedido;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cmbAparelho;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.CheckBox chkAparelho;
        private System.Windows.Forms.CheckBox chkDataPedido;
        private System.Windows.Forms.CheckBox chkValorPedido;
        private System.Windows.Forms.CheckBox chkFabricante;
        private System.Windows.Forms.DateTimePicker dateDataPedido1;
        private System.Windows.Forms.DateTimePicker dateDataPedido2;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.NumericUpDown numValorPedido1;
        private System.Windows.Forms.NumericUpDown numValorPedido2;
        private System.Windows.Forms.Label label1;
    }
}