namespace Conversor_de_Medidas
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
            this.textBoxCB2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBoxCB3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCB2
            // 
            this.textBoxCB2.Enabled = false;
            this.textBoxCB2.Location = new System.Drawing.Point(38, 117);
            this.textBoxCB2.Name = "textBoxCB2";
            this.textBoxCB2.Size = new System.Drawing.Size(115, 20);
            this.textBoxCB2.TabIndex = 0;
            this.textBoxCB2.TextChanged += new System.EventHandler(this.textBoxCB2_TextChanged);
            this.textBoxCB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCB2_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Temperatura",
            "Tempo",
            "Comprimento"});
            this.comboBox1.Location = new System.Drawing.Point(38, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(38, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(222, 137);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(115, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // textBoxCB3
            // 
            this.textBoxCB3.Enabled = false;
            this.textBoxCB3.Location = new System.Drawing.Point(222, 117);
            this.textBoxCB3.Name = "textBoxCB3";
            this.textBoxCB3.Size = new System.Drawing.Size(115, 20);
            this.textBoxCB3.TabIndex = 4;
            this.textBoxCB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCB3_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 196);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBoxCB3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxCB2);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCB2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBoxCB3;
    }
}

