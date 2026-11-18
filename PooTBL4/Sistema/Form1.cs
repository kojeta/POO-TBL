using System.Runtime.InteropServices;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        // Permite arrastar o Form segurando o painel superior (substitui a barra de titulo padrao)
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Botao de fechar (icone X no painel superior)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }

        // Botao Clientes (painel lateral)
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }
    }
}
