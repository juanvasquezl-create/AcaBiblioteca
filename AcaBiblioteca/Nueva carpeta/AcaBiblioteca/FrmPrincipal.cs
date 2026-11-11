namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            abrirformulario(new FrmInicio());
        }

        private void abrirformulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirformulario(new FrmInicio());
        }
    }


}
