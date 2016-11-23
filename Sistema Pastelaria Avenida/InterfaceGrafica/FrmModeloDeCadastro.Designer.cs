namespace InterfaceGrafica
{
    partial class FrmModeloDeCadastro
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
            this.pnbotoes = new System.Windows.Forms.Panel();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btCadastra = new System.Windows.Forms.Button();
            this.pndados = new System.Windows.Forms.Panel();
            this.pnbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnbotoes
            // 
            this.pnbotoes.Controls.Add(this.btAlterar);
            this.pnbotoes.Controls.Add(this.btSalvar);
            this.pnbotoes.Controls.Add(this.btCancelar);
            this.pnbotoes.Controls.Add(this.btExcluir);
            this.pnbotoes.Controls.Add(this.btLocalizar);
            this.pnbotoes.Controls.Add(this.btCadastra);
            this.pnbotoes.Location = new System.Drawing.Point(5, 12);
            this.pnbotoes.Name = "pnbotoes";
            this.pnbotoes.Size = new System.Drawing.Size(767, 100);
            this.pnbotoes.TabIndex = 0;
            // 
            // btAlterar
            // 
            this.btAlterar.Image = global::InterfaceGrafica.Properties.Resources.Alterar;
            this.btAlterar.Location = new System.Drawing.Point(271, 9);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(78, 72);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::InterfaceGrafica.Properties.Resources.Salvar1_fw;
            this.btSalvar.Location = new System.Drawing.Point(526, 9);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(78, 72);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::InterfaceGrafica.Properties.Resources.Cancelar;
            this.btCancelar.Location = new System.Drawing.Point(658, 9);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(78, 72);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::InterfaceGrafica.Properties.Resources.Excluir;
            this.btExcluir.Location = new System.Drawing.Point(404, 9);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(78, 72);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Image = global::InterfaceGrafica.Properties.Resources.localizar_fw;
            this.btLocalizar.Location = new System.Drawing.Point(143, 9);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(78, 72);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.Text = "Buscar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btCadastra
            // 
            this.btCadastra.Image = global::InterfaceGrafica.Properties.Resources.Novo;
            this.btCadastra.Location = new System.Drawing.Point(20, 9);
            this.btCadastra.Name = "btCadastra";
            this.btCadastra.Size = new System.Drawing.Size(78, 72);
            this.btCadastra.TabIndex = 5;
            this.btCadastra.Text = "Cadastrar";
            this.btCadastra.UseVisualStyleBackColor = true;
            // 
            // pndados
            // 
            this.pndados.Location = new System.Drawing.Point(5, 118);
            this.pndados.Name = "pndados";
            this.pndados.Size = new System.Drawing.Size(767, 403);
            this.pndados.TabIndex = 1;
            // 
            // FrmModeloDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pndados);
            this.Controls.Add(this.pnbotoes);
            this.Name = "FrmModeloDeCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeloDeFormularioDeCadastro";
            this.Load += new System.EventHandler(this.FrmModeloDeCadastro_Load);
            this.pnbotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnbotoes;
        protected System.Windows.Forms.Panel pndados;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btCadastra;
        protected System.Windows.Forms.Button btAlterar;
    }
}