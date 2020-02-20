namespace WindowsFormsArrays
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_Executar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmd_Executar
            // 
            this.cmd_Executar.Location = new System.Drawing.Point(680, 393);
            this.cmd_Executar.Name = "cmd_Executar";
            this.cmd_Executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_Executar.TabIndex = 0;
            this.cmd_Executar.Text = "Executar";
            this.cmd_Executar.UseVisualStyleBackColor = true;
            this.cmd_Executar.Click += new System.EventHandler(this.cmd_Executar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(59, 99);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(126, 329);
            this.listBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.cmd_Executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Executar;
        private System.Windows.Forms.ListBox listBox;
    }
}

