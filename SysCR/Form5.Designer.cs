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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lblsobre = new System.Windows.Forms.Label();
            this.lblnomeversao = new System.Windows.Forms.Label();
            this.lblnomecriador = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbllinkgit = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsobre
            // 
            this.lblsobre.AutoSize = true;
            this.lblsobre.Location = new System.Drawing.Point(12, 9);
            this.lblsobre.Name = "lblsobre";
            this.lblsobre.Size = new System.Drawing.Size(87, 13);
            this.lblsobre.TabIndex = 0;
            this.lblsobre.Text = "Sobre o Sistema:";
            // 
            // lblnomeversao
            // 
            this.lblnomeversao.AutoSize = true;
            this.lblnomeversao.Location = new System.Drawing.Point(38, 40);
            this.lblnomeversao.Name = "lblnomeversao";
            this.lblnomeversao.Size = new System.Drawing.Size(61, 13);
            this.lblnomeversao.TabIndex = 1;
            this.lblnomeversao.Text = "Versão: 1.0";
            // 
            // lblnomecriador
            // 
            this.lblnomecriador.AutoSize = true;
            this.lblnomecriador.Location = new System.Drawing.Point(38, 66);
            this.lblnomecriador.Name = "lblnomecriador";
            this.lblnomecriador.Size = new System.Drawing.Size(105, 13);
            this.lblnomecriador.TabIndex = 2;
            this.lblnomecriador.Text = "Criador: Davi Feitosa";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(78, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/DaviFeitosa21";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbllinkgit
            // 
            this.lbllinkgit.AutoSize = true;
            this.lbllinkgit.Location = new System.Drawing.Point(38, 94);
            this.lbllinkgit.Name = "lbllinkgit";
            this.lbllinkgit.Size = new System.Drawing.Size(43, 13);
            this.lbllinkgit.TabIndex = 4;
            this.lbllinkgit.Text = "GitHub:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(102, 131);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 166);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbllinkgit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblnomecriador);
            this.Controls.Add(this.lblnomeversao);
            this.Controls.Add(this.lblsobre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsobre;
        private System.Windows.Forms.Label lblnomeversao;
        private System.Windows.Forms.Label lblnomecriador;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbllinkgit;
        private System.Windows.Forms.Button btnFechar;
    }
}