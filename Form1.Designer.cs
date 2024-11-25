namespace WinFormsTabla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            resultado = new RichTextBox();
            ver = new Button();
            textBoxnum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Thistle;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(resultado);
            panelPrincipal.Controls.Add(ver);
            panelPrincipal.Controls.Add(textBoxnum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(794, 446);
            panelPrincipal.TabIndex = 0;
            // 
            // resultado
            // 
            resultado.Location = new Point(341, 49);
            resultado.Name = "resultado";
            resultado.Size = new Size(148, 182);
            resultado.TabIndex = 4;
            resultado.Text = "";
            resultado.TextChanged += resultado_TextChanged;
            // 
            // ver
            // 
            ver.Location = new Point(85, 196);
            ver.Name = "ver";
            ver.Size = new Size(95, 35);
            ver.TabIndex = 3;
            ver.Text = "ver tabla ";
            ver.UseVisualStyleBackColor = true;
            ver.Click += ver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(85, 144);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(139, 23);
            textBoxnum.TabIndex = 2;
            textBoxnum.TextChanged += textBoxnum_TextChanged;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelNumero.Location = new Point(76, 103);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(148, 20);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "Cual tabla quieres?";
            labelNumero.Click += label1_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(76, 49);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(177, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            labelTitulo.Click += labelTitulo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 5;
            label1.Text = "salvador olivares";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelTitulo;
        private Label labelNumero;
        private TextBox textBoxnum;
        private Button ver;
        private RichTextBox resultado;
        private Label label1;
    }
}
