using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Buffers;

namespace Cadastro_Clientes
{

    partial class frmCadastroAparelhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroAparelhos));
            this.llblID = new System.Windows.Forms.Label();
            this.txtID_Aparelho = new System.Windows.Forms.TextBox();
            this.chkbExcluido = new System.Windows.Forms.CheckBox();
            this.dgvAparelhos = new System.Windows.Forms.DataGridView();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEspessura = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.numEspessura = new System.Windows.Forms.NumericUpDown();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblQtdeEstoque = new System.Windows.Forms.Label();
            this.numLargura = new System.Windows.Forms.NumericUpDown();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numQtde_estoque = new System.Windows.Forms.NumericUpDown();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblnome_fab = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparelhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtde_estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // llblID
            // 
            this.llblID.AutoSize = true;
            this.llblID.BackColor = System.Drawing.Color.Transparent;
            this.llblID.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblID.Location = new System.Drawing.Point(75, 307);
            this.llblID.Name = "llblID";
            this.llblID.Size = new System.Drawing.Size(82, 14);
            this.llblID.TabIndex = 0;
            this.llblID.Text = "ID aparelho:";
            // 
            // txtID_Aparelho
            // 
            this.txtID_Aparelho.Location = new System.Drawing.Point(182, 300);
            this.txtID_Aparelho.Name = "txtID_Aparelho";
            this.txtID_Aparelho.Size = new System.Drawing.Size(108, 20);
            this.txtID_Aparelho.TabIndex = 2;
            this.txtID_Aparelho.Validated += new System.EventHandler(this.txtID_Aparelho_Validated);
            // 
            // chkbExcluido
            // 
            this.chkbExcluido.AutoSize = true;
            this.chkbExcluido.BackColor = System.Drawing.Color.Transparent;
            this.chkbExcluido.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbExcluido.Location = new System.Drawing.Point(603, 303);
            this.chkbExcluido.Name = "chkbExcluido";
            this.chkbExcluido.Size = new System.Drawing.Size(84, 18);
            this.chkbExcluido.TabIndex = 4;
            this.chkbExcluido.Text = "Excluído?";
            this.chkbExcluido.UseVisualStyleBackColor = false;
            // 
            // dgvAparelhos
            // 
            this.dgvAparelhos.AllowUserToAddRows = false;
            this.dgvAparelhos.AllowUserToDeleteRows = false;
            this.dgvAparelhos.AllowUserToResizeColumns = false;
            this.dgvAparelhos.AllowUserToResizeRows = false;
            this.dgvAparelhos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAparelhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAparelhos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAparelhos.Location = new System.Drawing.Point(78, 95);
            this.dgvAparelhos.Name = "dgvAparelhos";
            this.dgvAparelhos.ReadOnly = true;
            this.dgvAparelhos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAparelhos.Size = new System.Drawing.Size(609, 166);
            this.dgvAparelhos.TabIndex = 1;
            this.dgvAparelhos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAparelhos_CellEnter);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(75, 344);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 14);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(75, 404);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(85, 14);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura (cm):";
            // 
            // lblEspessura
            // 
            this.lblEspessura.AutoSize = true;
            this.lblEspessura.BackColor = System.Drawing.Color.Transparent;
            this.lblEspessura.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspessura.Location = new System.Drawing.Point(75, 451);
            this.lblEspessura.Name = "lblEspessura";
            this.lblEspessura.Size = new System.Drawing.Size(105, 14);
            this.lblEspessura.TabIndex = 8;
            this.lblEspessura.Text = "Espessura (cm):";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(75, 497);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(44, 14);
            this.lblPreco.TabIndex = 9;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lblDesconto.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.lblDesconto.Location = new System.Drawing.Point(75, 540);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(92, 14);
            this.lblDesconto.TabIndex = 10;
            this.lblDesconto.Text = "Desconto (%):";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(182, 337);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(505, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // numEspessura
            // 
            this.numEspessura.DecimalPlaces = 2;
            this.numEspessura.Location = new System.Drawing.Point(182, 449);
            this.numEspessura.Name = "numEspessura";
            this.numEspessura.Size = new System.Drawing.Size(120, 20);
            this.numEspessura.TabIndex = 7;
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Location = new System.Drawing.Point(182, 398);
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(120, 20);
            this.numAltura.TabIndex = 6;
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Location = new System.Drawing.Point(182, 490);
            this.numPreco.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(120, 20);
            this.numPreco.TabIndex = 8;
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 2;
            this.numDesconto.Location = new System.Drawing.Point(182, 534);
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(120, 20);
            this.numDesconto.TabIndex = 9;
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.BackColor = System.Drawing.Color.Transparent;
            this.lblLargura.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargura.Location = new System.Drawing.Point(393, 406);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(93, 14);
            this.lblLargura.TabIndex = 16;
            this.lblLargura.Text = "Largura (cm):";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.lblPeso.Location = new System.Drawing.Point(393, 455);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(56, 14);
            this.lblPeso.TabIndex = 17;
            this.lblPeso.Text = "Peso (g)";
            // 
            // lblQtdeEstoque
            // 
            this.lblQtdeEstoque.AutoSize = true;
            this.lblQtdeEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdeEstoque.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.lblQtdeEstoque.Location = new System.Drawing.Point(393, 496);
            this.lblQtdeEstoque.Name = "lblQtdeEstoque";
            this.lblQtdeEstoque.Size = new System.Drawing.Size(132, 14);
            this.lblQtdeEstoque.TabIndex = 18;
            this.lblQtdeEstoque.Text = "Quantidade estoque:";
            // 
            // numLargura
            // 
            this.numLargura.DecimalPlaces = 2;
            this.numLargura.Location = new System.Drawing.Point(536, 400);
            this.numLargura.Name = "numLargura";
            this.numLargura.Size = new System.Drawing.Size(151, 20);
            this.numLargura.TabIndex = 10;
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Location = new System.Drawing.Point(536, 445);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(151, 20);
            this.numPeso.TabIndex = 11;
            // 
            // numQtde_estoque
            // 
            this.numQtde_estoque.Location = new System.Drawing.Point(536, 490);
            this.numQtde_estoque.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQtde_estoque.Name = "numQtde_estoque";
            this.numQtde_estoque.Size = new System.Drawing.Size(151, 20);
            this.numQtde_estoque.TabIndex = 12;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnNovo.Location = new System.Drawing.Point(78, 621);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(215, 621);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(352, 621);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(488, 621);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnSair.Location = new System.Drawing.Point(612, 621);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(219, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 31);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Cadastro de Aparelhos";
            // 
            // lblnome_fab
            // 
            this.lblnome_fab.AutoSize = true;
            this.lblnome_fab.BackColor = System.Drawing.Color.Transparent;
            this.lblnome_fab.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome_fab.Location = new System.Drawing.Point(308, 306);
            this.lblnome_fab.Name = "lblnome_fab";
            this.lblnome_fab.Size = new System.Drawing.Size(77, 14);
            this.lblnome_fab.TabIndex = 28;
            this.lblnome_fab.Text = "Fabricante:";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(396, 299);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(152, 21);
            this.cmbFabricante.TabIndex = 3;
            // 
            // frmCadastroAparelhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 693);
            this.ControlBox = false;
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.lblnome_fab);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.numQtde_estoque);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.numLargura);
            this.Controls.Add(this.lblQtdeEstoque);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.numDesconto);
            this.Controls.Add(this.numPreco);
            this.Controls.Add(this.numAltura);
            this.Controls.Add(this.numEspessura);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblEspessura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.dgvAparelhos);
            this.Controls.Add(this.chkbExcluido);
            this.Controls.Add(this.txtID_Aparelho);
            this.Controls.Add(this.llblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroAparelhos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aparelhos";
            this.Load += new System.EventHandler(this.frmCadastroAparelhos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAparelhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspessura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtde_estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llblID;
        private System.Windows.Forms.TextBox txtID_Aparelho;
        private System.Windows.Forms.CheckBox chkbExcluido;
        private System.Windows.Forms.DataGridView dgvAparelhos;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEspessura;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown numEspessura;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblQtdeEstoque;
        private System.Windows.Forms.NumericUpDown numLargura;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.NumericUpDown numQtde_estoque;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblnome_fab;
        private System.Windows.Forms.ComboBox cmbFabricante;
    }
}