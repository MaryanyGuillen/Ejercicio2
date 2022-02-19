namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int Cantidad;
            int Contador = -1;

            Cantidad = Convert.ToInt32(CantidadDatosTextBox.Text);
            string[] Nombres = new string[Cantidad];
            int[] Edades = new int[Cantidad];
            Contador = Contador + 1;
            Nombres[Contador] = Convert.ToString(NombreTextBox.Text);
            Edades[Contador] = Convert.ToInt32(EdadTextBox.Text);
            NombreTextBox.Clear();
            EdadTextBox.Clear();

            for (int i = 0; i < Cantidad; i++)
            {
                DatosComboBox.Items.Add(Nombres[i] + "          " + "           " + Edades[i]);
            }

        }
                        
    }
}
   