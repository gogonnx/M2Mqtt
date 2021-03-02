using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;
using System.Net;

namespace MQTTClient
{
    public partial class Form1 : Form
    {
        private static volatile MqttClientService _instance;
        private static readonly object LockHelper = new object();
        //连接broker的信息（暂时broker设置匿名访问，用户名和密码随便）
        private static string EMQX_BROKER_IP = "192.168.10.165";
        private static int EMQX_BROKER_PORT = 1884;
        private string EMQX_CLIENT_ID = null;
        private static string EMQX_USER_NAME = "unityManager";
        private static string EMQX_PASSWORD = "unity";
        private byte qos = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
        private List<string> messageArray = new List<string>();
        private List<string> messageArray1 = new List<string>();
        public MqttClient mqttClient { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            EMQX_BROKER_IP = iptxt.Text;
            EMQX_BROKER_PORT = int.Parse(porttxt.Text);
            EMQX_CLIENT_ID = Guid.NewGuid().ToString();
            try
            {
                mqttClient = new MqttClient(EMQX_BROKER_IP, EMQX_BROKER_PORT, false, null, null, MqttSslProtocols.TLSv1_2);
                // mqttClient = new MqttClient(IPAddress.Parse(EMQX_BROKER_IP));
                mqttClient.Connect(EMQX_CLIENT_ID);
                mqttClient.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                connectbtn.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string topic = e.Topic.ToString();
            string message = System.Text.Encoding.Default.GetString(e.Message);
            // MessageBox.Show("订阅的主题是"+topic+"主题的内容是"+message);
            if (topic == subscribetopictxt.Text)
            {
                messageArray.Add(message);
            }
            if (topic == subscribetopictxt1.Text)
            {
                messageArray1.Add(message);
            }
            //reciveTopic.Text = topic;
            //reciveMessagetxt.Text = message;

        }
        public void publishTopic(string currentTopic, string content)
        {            
            if (mqttClient != null && !string.IsNullOrEmpty(currentTopic) && !string.IsNullOrEmpty(content))
            {
                mqttClient.Publish(currentTopic, System.Text.Encoding.UTF8.GetBytes(content), qos, true);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                 publishTopic(publishtopictxt.Text, sendMessagetxt.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void subscribebtn_Click(object sender, EventArgs e)
        {
            mqttClient.Subscribe(new string[] { subscribetopictxt.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

        }

        private void publishBtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (messageArray.Count > 0)
            {
                reciveMessagetxt.Text = messageArray[0];
                messageArray.RemoveAt(0);
            }
            else
            {
                reciveMessagetxt.Text = "没有新消息";
            }
            if (messageArray1.Count > 0)
            {
                reciveMessagetxt1.Text = messageArray1[0];
                messageArray1.RemoveAt(0);
            }
            else
            {
                reciveMessagetxt1.Text = "没有新消息";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mqttClient.Subscribe(new string[] { subscribetopictxt1.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                publishTopic(publishtopictxt1.Text, sendMessagetxt1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
