using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Packets;
using MQTTnet.Server;

namespace DoNhietDo
{
    public partial class Form1 : Form
    {
        private IMqttClient _mqttClient;

        public Form1()
        {
            InitializeComponent();
            String[] Baudrate = { "2400", "9600", "115200" };
            cboBaudrate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBaudrate.Text = "9600";
            cboCOM.DataSource = SerialPort.GetPortNames();
        }

        private  void butConnect_Click(object sender, EventArgs e)
        {
            serCOM.PortName = cboCOM.Text;
            serCOM.BaudRate = Convert.ToInt32(cboBaudrate.Text);
             
         

            try
            {
                serCOM.Open();
                if (serCOM.IsOpen)
                {
                    lbTrangthai.Text = "Da Ket Noi";
                    lbTrangthai.ForeColor = Color.Green;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Không thể truy cập cổng. Hãy đảm bảo rằng cổng không đang được sử dụng bởi ứng dụng khác và bạn có quyền cần thiết.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButDisconnect_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            if (!serCOM.IsOpen)
            {
                lbTrangthai.Text = "Da Mgat Ket Noi";
                lbTrangthai.ForeColor = Color.Red;
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String Data = "";
            Data = serCOM.ReadLine();
            txtDataReceived.Text = Data;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            
        }

    


    }
}
