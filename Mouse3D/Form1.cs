using MQTTnet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mouse3D
{
    public partial class Form1 : Form
    {
        public delegate void ChangedEventHandle(string id, string field, string payload, string timestamp);

        MQTTComunicacao clienteMQTT = new MQTTComunicacao();
        TDx.TDxInput.Device device;
        TDx.TDxInput.Sensor sensor;

        int a, b, c, d,e1,f;
        int oldA, oldB, oldC, oldD,oldE,oldF;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;
            string sUrl;
            int porta;

            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            sUrl = txtUrl.Text;

            if (!int.TryParse(txtPorta.Text, out porta))
            {
                MessageBox.Show("Porta configurada não é um número");
            }
            else
            {

                clienteMQTT = new MQTTComunicacao();

                clienteMQTT.ConnectAsync("teste",sUrl,porta,usuario,senha);

                //clienteMQTT.Received += new ChangedEventHandle(MonitoraCanal);

                //Conexão com Mouse
                device = new TDx.TDxInput.Device(); // ****************** this line causes the problem
                device.Connect();
                sensor = device.Sensor;
                timer1.Enabled = true;

                if (device.IsConnected)
                    lbConectado.Visible = true;
            }
        }

        /// <summary>
        /// Monitora Canal de entrada 
        /// </summary>
        private void MonitoraCanal(string id, string field, string payload, string timestamp)
        {
            //label1.Text = payload;
            
            //
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clienteMQTT.Publish("teste", "1");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Stx.Text = sensor.Translation.X.ToString();
            Stz.Text = sensor.Translation.Z.ToString();
            Dtx.Text = sensor.Translation.X.ToString();
            Dtz.Text = sensor.Translation.Z.ToString();
            if (tabControl1.SelectedTab.Name == "sobe")
            {
                // FRENTE
                if ((Convert.ToInt32(sensor.Translation.X) >= 0 && Convert.ToInt32(sensor.Translation.Z) < 0)
                    || (Convert.ToInt32(sensor.Translation.X) < 0 && Convert.ToInt32(sensor.Translation.Z) < 0))
                    a = 1;
                else
                    a = 0;
                // ATRÁS
                if ((Convert.ToInt32(sensor.Translation.X) <= 0 && Convert.ToInt32(sensor.Translation.Z) > 0)
                    || (Convert.ToInt32(sensor.Translation.X) > 0 && Convert.ToInt32(sensor.Translation.Z) > 0))
                    b = 1;
                else
                    b = 0;
            }
            if (tabControl1.SelectedTab.Name == "direita")
            {
                //DIREITA
                if ((Convert.ToInt32(sensor.Translation.Z) <= 0 && Convert.ToInt32(sensor.Translation.X) < 0) 
                    || (Convert.ToInt32(sensor.Translation.Z) > 0 && Convert.ToInt32(sensor.Translation.X) < 0))
                    c = 1;
                else
                    c = 0;
                //ESQUERDA
                if ((Convert.ToInt32(sensor.Translation.Z) >= 0 && Convert.ToInt32(sensor.Translation.X) > 0) 
                     || (Convert.ToInt32(sensor.Translation.Z) < 0 && Convert.ToInt32(sensor.Translation.X) > 0))
                    d = 1;
                else
                    d = 0;
            }

            if (tabControl1.SelectedTab.Name == "rotacao")
            {
                //ROTAÇÃO DIREITA
                if (Convert.ToInt32(sensor.Rotation.Y) > 0 && f==0)
                    e1 = 1;
                else
                    e1 = 0;
                //ROTACAO ESQUERDA
                if (Convert.ToInt32(sensor.Rotation.Y) < 0 && e1==0)
                    f = 1;
                else
                    f = 0;
            }

                if (oldA != a)
            {
                oldA = a;
                lbA.Text = a.ToString();
                clienteMQTT.Publish("Sobe", a.ToString());
            }

            if (oldB != b)
            {
                oldB = b;
                lbB.Text = b.ToString();
                clienteMQTT.Publish("Desce", b.ToString());
            }

            if (oldC != c)
            {
                oldC = c;
                lbC.Text = c.ToString();
                clienteMQTT.Publish("Esquerda", c.ToString());
            }

            if (oldD != d)
            {
                oldD = d;
                lbD.Text = d.ToString();
                clienteMQTT.Publish("Direita", d.ToString());
            }

            if (oldE != e1)
            {
                oldE = e1;
                lbE.Text = e1.ToString();
                clienteMQTT.Publish("R Esquerda", e1.ToString());
            }

            if (oldF != f)
            {
                oldF = f;
                lbF.Text = f.ToString();
                clienteMQTT.Publish("R Direita", f.ToString());
            }



        }

        //public async Task<bool> Escrever()
        //{
        //    await 
        //}
    }
}
