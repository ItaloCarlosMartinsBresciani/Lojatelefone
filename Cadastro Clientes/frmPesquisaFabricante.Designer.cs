
namespace Cadastro_Clientes
{
    partial class frmPesquisaFabricante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaFabricante));
            this.dgvFabricantes = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblId_fabricante = new System.Windows.Forms.Label();
            this.lblNome_fabricante = new System.Windows.Forms.Label();
            this.txtId_Fabricante = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNome_fabricante = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFabricantes
            // 
            this.dgvFabricantes.AllowUserToAddRows = false;
            this.dgvFabricantes.AllowUserToDeleteRows = false;
            this.dgvFabricantes.AllowUserToResizeColumns = false;
            this.dgvFabricantes.AllowUserToResizeRows = false;
            this.dgvFabricantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFabricantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFabricantes.Location = new System.Drawing.Point(82, 121);
            this.dgvFabricantes.Name = "dgvFabricantes";
            this.dgvFabricantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFabricantes.Size = new System.Drawing.Size(611, 239);
            this.dgvFabricantes.TabIndex = 0;
            this.dgvFabricantes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFabricantes_CellEnter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(469, 467);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 31);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(82, 467);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 31);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 31);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Pesquisa de Fabricantes";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(592, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 31);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblId_fabricante
            // 
            this.lblId_fabricante.AutoSize = true;
            this.lblId_fabricante.BackColor = System.Drawing.Color.Transparent;
            this.lblId_fabricante.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_fabricante.Location = new System.Drawing.Point(177, 413);
            this.lblId_fabricante.Name = "lblId_fabricante";
            this.lblId_fabricante.Size = new System.Drawing.Size(99, 15);
            this.lblId_fabricante.TabIndex = 17;
            this.lblId_fabricante.Text = "ID fabricante:";
            // 
            // lblNome_fabricante
            // 
            this.lblNome_fabricante.AutoSize = true;
            this.lblNome_fabricante.BackColor = System.Drawing.Color.Transparent;
            this.lblNome_fabricante.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_fabricante.Location = new System.Drawing.Point(423, 413);
            this.lblNome_fabricante.Name = "lblNome_fabricante";
            this.lblNome_fabricante.Size = new System.Drawing.Size(50, 15);
            this.lblNome_fabricante.TabIndex = 18;
            this.lblNome_fabricante.Text = "Nome:";
            // 
            // txtId_Fabricante
            // 
            this.txtId_Fabricante.Location = new System.Drawing.Point(282, 408);
            this.txtId_Fabricante.Name = "txtId_Fabricante";
            this.txtId_Fabricante.Size = new System.Drawing.Size(90, 20);
            this.txtId_Fabricante.TabIndex = 19;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(212, 467);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 31);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNome_fabricante
            // 
            this.txtNome_fabricante.Location = new System.Drawing.Point(479, 408);
            this.txtNome_fabricante.Name = "txtNome_fabricante";
            this.txtNome_fabricante.Size = new System.Drawing.Size(130, 20);
            this.txtNome_fabricante.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(342, 467);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 31);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmPesquisaFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome_fabricante);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtId_Fabricante);
            this.Controls.Add(this.lblNome_fabricante);
            this.Controls.Add(this.lblId_fabricante);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvFabricantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisaFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisaFabricante";
            this.Load += new System.EventHandler(this.frmPesquisaFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFabricantes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblId_fabricante;
        private System.Windows.Forms.Label lblNome_fabricante;
        private System.Windows.Forms.TextBox txtId_Fabricante;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNome_fabricante;
        private System.Windows.Forms.Button btnSalvar;
    }
}