using System.IO.Ports;

namespace PuertoSerie
{
    public partial class frmSerie : Form
    {
        SerialPort sp = new SerialPort();

        public frmSerie()
        {
            InitializeComponent();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            cmbPuertos.DataSource = puertos;
            // Muestra el valor inicial del trackBar en labelValor
            labelValor.Text = trackBar1.Value.ToString();
            labelValor.Hide();
            label3.ForeColor = Color.White;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = cmbPuertos.Text;
                sp.BaudRate = 9600; // Configura la velocidad de baudios según la configurada en Arduino
                sp.Open();
                MessageBox.Show("Conectado");
                sp.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                sp.WriteLine("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort actualSP = (SerialPort)sender;


            //string inData = actualSP.ReadLine();


            /*rtbLog.Invoke(new MethodInvoker(
                        delegate
                        {
                            rtbLog.Text = rtbLog.Text + inData;
                        }

                        ));*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            cmbPuertos.DataSource = puertos;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int angle = trackBar1.Value;
            label3.Text = "Ángulo: " + angle.ToString() + "°";

            // Verificar que el puerto esté abierto antes de enviar el dato
            if (sp.IsOpen)
            {
                try
                {
                    sp.WriteLine(angle.ToString()); // Enviar el ángulo al Arduino
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El puerto serial no está abierto.");
            }
        }

    }
}
