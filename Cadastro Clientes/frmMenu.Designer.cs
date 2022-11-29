
namespace Cadastro_Clientes
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            this.btnCadastroAparelhos = new System.Windows.Forms.Button();
            this.btnCadastroFabricantes = new System.Windows.Forms.Button();
            this.btnPesquisaFabricante = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar_pedidos = new System.Windows.Forms.Button();
            this.btnPesquisaPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroClientes.Location = new System.Drawing.Point(101, 123);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(185, 30);
            this.btnCadastroClientes.TabIndex = 1;
            this.btnCadastroClientes.Text = "&Cadastrar Clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // btnCadastroAparelhos
            // 
            this.btnCadastroAparelhos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroAparelhos.Location = new System.Drawing.Point(396, 206);
            this.btnCadastroAparelhos.Name = "btnCadastroAparelhos";
            this.btnCadastroAparelhos.Size = new System.Drawing.Size(185, 28);
            this.btnCadastroAparelhos.TabIndex = 3;
            this.btnCadastroAparelhos.Text = "&Cadastrar Aparelhos";
            this.btnCadastroAparelhos.UseVisualStyleBackColor = true;
            this.btnCadastroAparelhos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnCadastroFabricantes
            // 
            this.btnCadastroFabricantes.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFabricantes.Location = new System.Drawing.Point(101, 205);
            this.btnCadastroFabricantes.Name = "btnCadastroFabricantes";
            this.btnCadastroFabricantes.Size = new System.Drawing.Size(185, 30);
            this.btnCadastroFabricantes.TabIndex = 2;
            this.btnCadastroFabricantes.Text = "&Cadastrar Fabricantes";
            this.btnCadastroFabricantes.UseVisualStyleBackColor = true;
            this.btnCadastroFabricantes.Click += new System.EventHandler(this.btnCadastroFabricantes_Click);
            // 
            // btnPesquisaFabricante
            // 
            this.btnPesquisaFabricante.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaFabricante.Location = new System.Drawing.Point(31, 289);
            this.btnPesquisaFabricante.Name = "btnPesquisaFabricante";
            this.btnPesquisaFabricante.Size = new System.Drawing.Size(182, 30);
            this.btnPesquisaFabricante.TabIndex = 5;
            this.btnPesquisaFabricante.Text = "&Pesquisar Fabricantes";
            this.btnPesquisaFabricante.UseVisualStyleBackColor = true;
            this.btnPesquisaFabricante.Click += new System.EventHandler(this.btnPesquisaFabricante_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaCliente.Location = new System.Drawing.Point(491, 289);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(182, 30);
            this.btnPesquisaCliente.TabIndex = 6;
            this.btnPesquisaCliente.Text = "&Pesquisar Clientes";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(299, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 28);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(293, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 36);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Menu";
            // 
            // btnCadastrar_pedidos
            // 
            this.btnCadastrar_pedidos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar_pedidos.Location = new System.Drawing.Point(396, 125);
            this.btnCadastrar_pedidos.Name = "btnCadastrar_pedidos";
            this.btnCadastrar_pedidos.Size = new System.Drawing.Size(185, 28);
            this.btnCadastrar_pedidos.TabIndex = 4;
            this.btnCadastrar_pedidos.Text = "&Cadastrar Pedidos";
            this.btnCadastrar_pedidos.UseVisualStyleBackColor = true;
            this.btnCadastrar_pedidos.Click += new System.EventHandler(this.btnCadastrar_pedidos_Click);
            // 
            // btnPesquisaPedidos
            // 
            this.btnPesquisaPedidos.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaPedidos.Location = new System.Drawing.Point(259, 289);
            this.btnPesquisaPedidos.Name = "btnPesquisaPedidos";
            this.btnPesquisaPedidos.Size = new System.Drawing.Size(182, 30);
            this.btnPesquisaPedidos.TabIndex = 8;
            this.btnPesquisaPedidos.Text = "&Pesquisar Pedidos";
            this.btnPesquisaPedidos.UseVisualStyleBackColor = true;
            this.btnPesquisaPedidos.Click += new System.EventHandler(this.btnPesquisaPedidos_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnPesquisaPedidos);
            this.Controls.Add(this.btnCadastrar_pedidos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.btnPesquisaFabricante);
            this.Controls.Add(this.btnCadastroFabricantes);
            this.Controls.Add(this.btnCadastroAparelhos);
            this.Controls.Add(this.btnCadastroClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroClientes;
        private System.Windows.Forms.Button btnCadastroAparelhos;
        private System.Windows.Forms.Button btnCadastroFabricantes;
        private System.Windows.Forms.Button btnPesquisaFabricante;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCadastrar_pedidos;
        private System.Windows.Forms.Button btnPesquisaPedidos;
    }
}