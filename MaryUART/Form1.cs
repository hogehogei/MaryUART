using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MaryUART
{
    public partial class MaryUART : Form
    {
        private SerialPort mSerialPort;

        public MaryUART()
        {
            InitializeComponent();
            mSerialPort = null;
        }

        ~MaryUART()
        {
            if (mSerialPort != null)
            {
                mSerialPort.Close();
                mSerialPort = null;
            }
        }

        private void MaryUART_Load(object sender, EventArgs e)
        {
            // 使用可能なCOMポートをリストに追加
            foreach (var port in SerialPort.GetPortNames())
            {
                COMPortMenu.Items.Add(port);
            }
            BaudrateMenu.SelectedIndex = 0;
            DatabitsMenu.SelectedIndex = 0;
            ParityMenu.SelectedIndex = 0;
            StopBitsMenu.SelectedIndex = 0;
        }

        private void UARTSendButton_Click(object sender, EventArgs e)
        {
            if (mSerialPort != null && mSerialPort.IsOpen)
            {
                string text = SendTextBox.Text;
                mSerialPort.WriteLine(SendTextBox.Text);
            }
        }

        private void UARTRecvData(object sender, EventArgs e)
        {
            if (mSerialPort != null && mSerialPort.IsOpen)
            {
                string text = mSerialPort.ReadExisting();
                RecvTextBox.AppendText(text);
            }
        }

        private void UARTOpenButton_Click(object sender, EventArgs e)
        {
            string port_name = COMPortMenu.SelectedItem.ToString();
            int baudrate = Int32.Parse(BaudrateMenu.SelectedItem.ToString());
            int databits = Int32.Parse(DatabitsMenu.SelectedItem.ToString());
            // これはとりあえず決め打ち
            Parity parity = Parity.None;
            StopBits stopbits = StopBits.One;

            try
            {
                if (mSerialPort != null)
                {
                    // すでにオープンされているシリアルポートがあるのでそれをクローズする
                    mSerialPort.Close();
                }
                mSerialPort = new SerialPort(port_name, baudrate, parity, databits, stopbits);
                mSerialPort.Open();

                // シリアルポートをリセット
                mSerialPort.DtrEnable = false;
                mSerialPort.RtsEnable = false;
                System.Threading.Thread.Sleep(1000);
                mSerialPort.DtrEnable = true;
                System.Threading.Thread.Sleep(1000);
                mSerialPort.DtrEnable = false;
            }
            catch (SystemException ex)
            {
                MessageBox.Show("シリアルポートのオープンに失敗しました。");
                return;
            }

            // シリアルポートオープンしたのでステータス表示を接続中に
            StatusLabel.BackColor = System.Drawing.Color.ForestGreen;
            StatusLabel.Text = "接続中";
        }

        private void UARTCloseButton_Click(object sender, EventArgs e)
        {
            if (mSerialPort != null)
            {
                mSerialPort.Close();
                mSerialPort = null;

                // シリアルポートオープンしたのでステータス表示を接続待ちに
                StatusLabel.BackColor = System.Drawing.Color.Crimson;
                StatusLabel.Text = "接続待ち";
            }
        }
    }
}
