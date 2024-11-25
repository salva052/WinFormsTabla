namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void ver_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void textBoxnum_TextChanged(object sender, EventArgs e)
        {

        }
        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = " ";
            for (int i = 0; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.resultado.AppendText(tabla);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
