namespace loginex
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtclave.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "elizalde@siguemed.com.mx" && txtclave.Text == "Lupita123.")
            {
                Frminicio frminicio = new Frminicio();
                this.Hide();
                frminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtusuario.Clear();
                txtclave.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
