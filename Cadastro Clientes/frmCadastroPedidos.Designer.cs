
namespace Cadastro_Clientes
{
    partial class frmCadastroPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroPedidos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblID_Pedido = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txtID_Pedido = new System.Windows.Forms.TextBox();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.txtObservações = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(260, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Pedidos";
            // 
            // lblID_Pedido
            // 
            this.lblID_Pedido.AutoSize = true;
            this.lblID_Pedido.BackColor = System.Drawing.Color.Transparent;
            this.lblID_Pedido.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_Pedido.Location = new System.Drawing.Point(143, 121);
            this.lblID_Pedido.Name = "lblID_Pedido";
            this.lblID_Pedido.Size = new System.Drawing.Size(75, 15);
            this.lblID_Pedido.TabIndex = 1;
            this.lblID_Pedido.Text = "ID Pedido:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.lblData.Location = new System.Drawing.Point(143, 161);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(128, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data/Hora Pedido:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.lblObservacao.Location = new System.Drawing.Point(143, 197);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(92, 15);
            this.lblObservacao.TabIndex = 4;
            this.lblObservacao.Text = "Observações:";
            // 
            // dgPedidos
            // 
            this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Location = new System.Drawing.Point(74, 390);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(632, 180);
            this.dgPedidos.TabIndex = 5;
            this.dgPedidos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPedidos_CellEnter);
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Produto.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.lbl_Produto.Location = new System.Drawing.Point(143, 336);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(66, 15);
            this.lbl_Produto.TabIndex = 6;
            this.lbl_Produto.Text = "Produto:";
            // 
            // txtID_Pedido
            // 
            this.txtID_Pedido.Location = new System.Drawing.Point(300, 116);
            this.txtID_Pedido.Name = "txtID_Pedido";
            this.txtID_Pedido.Size = new System.Drawing.Size(155, 20);
            this.txtID_Pedido.TabIndex = 10;
            this.txtID_Pedido.Validated += new System.EventHandler(this.txtID_Pedido_Validated);
            // 
            // dtPedido
            // 
            this.dtPedido.Location = new System.Drawing.Point(300, 156);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(341, 20);
            this.dtPedido.TabIndex = 12;
            // 
            // txtObservações
            // 
            this.txtObservações.Location = new System.Drawing.Point(300, 195);
            this.txtObservações.Multiline = true;
            this.txtObservações.Name = "txtObservações";
            this.txtObservações.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservações.Size = new System.Drawing.Size(341, 122);
            this.txtObservações.TabIndex = 13;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(333, 613);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 23);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(72, 613);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(79, 23);
            this.btnNovo.TabIndex = 32;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(612, 613);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 23);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(475, 613);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(205, 613);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 23);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(300, 334);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(339, 21);
            this.cmbProduto.TabIndex = 34;
            // 
            // frmCadastroPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 663);
            this.ControlBox = false;
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservações);
            this.Controls.Add(this.dtPedido);
            this.Controls.Add(this.txtID_Pedido);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblID_Pedido);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastroPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblID_Pedido;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txtID_Pedido;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.TextBox txtObservações;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbProduto;
    }
}