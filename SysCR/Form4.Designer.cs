namespace SysCR
{
    partial class Form4
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantProduto = new System.Windows.Forms.TextBox();
            this.lblQuantProduto = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.btnGravarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(331, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(100, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(70, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 20);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "✜";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(100, 68);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(103, 84);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(331, 20);
            this.txtProduto.TabIndex = 6;
            // 
            // txtQuantProduto
            // 
            this.txtQuantProduto.Location = new System.Drawing.Point(103, 134);
            this.txtQuantProduto.Name = "txtQuantProduto";
            this.txtQuantProduto.Size = new System.Drawing.Size(90, 20);
            this.txtQuantProduto.TabIndex = 7;
            // 
            // lblQuantProduto
            // 
            this.lblQuantProduto.AutoSize = true;
            this.lblQuantProduto.Location = new System.Drawing.Point(100, 118);
            this.lblQuantProduto.Name = "lblQuantProduto";
            this.lblQuantProduto.Size = new System.Drawing.Size(65, 13);
            this.lblQuantProduto.TabIndex = 8;
            this.lblQuantProduto.Text = "Quantidade:";
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Location = new System.Drawing.Point(196, 118);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(34, 13);
            this.lblValorProduto.TabIndex = 9;
            this.lblValorProduto.Text = "Valor:";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(199, 134);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(100, 20);
            this.txtValorProduto.TabIndex = 10;
            // 
            // btnGravarVenda
            // 
            this.btnGravarVenda.Location = new System.Drawing.Point(359, 134);
            this.btnGravarVenda.Name = "btnGravarVenda";
            this.btnGravarVenda.Size = new System.Drawing.Size(75, 20);
            this.btnGravarVenda.TabIndex = 11;
            this.btnGravarVenda.Text = "Gravar";
            this.btnGravarVenda.UseVisualStyleBackColor = true;
            this.btnGravarVenda.Click += new System.EventHandler(this.btnGravarVenda_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 170);
            this.Controls.Add(this.btnGravarVenda);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblQuantProduto);
            this.Controls.Add(this.txtQuantProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendas/Orçamentos";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantProduto;
        private System.Windows.Forms.Label lblQuantProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Button btnGravarVenda;
    }
}