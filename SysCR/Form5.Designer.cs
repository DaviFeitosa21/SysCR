namespace SysCR
{
    partial class Form5
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisaClientes = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(57, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(73, 23);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(42, 13);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(76, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(471, 20);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // btnPesquisaClientes
            // 
            this.btnPesquisaClientes.Location = new System.Drawing.Point(553, 39);
            this.btnPesquisaClientes.Name = "btnPesquisaClientes";
            this.btnPesquisaClientes.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisaClientes.TabIndex = 4;
            this.btnPesquisaClientes.Text = "Pesquisar";
            this.btnPesquisaClientes.UseVisualStyleBackColor = true;
            this.btnPesquisaClientes.Click += new System.EventHandler(this.btnPesquisaClientes_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.HideSelection = false;
            this.lstClientes.Location = new System.Drawing.Point(16, 77);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(1112, 255);
            this.lstClientes.TabIndex = 5;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstClientes_ItemSelectionChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 351);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnPesquisaClientes);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnPesquisaClientes;
        private System.Windows.Forms.ListView lstClientes;
    }
}