using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;


namespace MQTTClient
{
    public class MqttClientService
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

        private string subTopic = "lengzha001";
        private string testTopic = "lengzha002";
        private string receiveMsg;
        private bool isStart;
        private bool isStart2;
        //private ValuesVO vo;
        private Dictionary<string, dynamic> dic;
        List<string> topics = new List<string>();



        private Dictionary<string, string> deviceTopicDict;

        public const string topicSteelCoil2 = "SteelCoil2";
        public const string topicPayOffReal2 = "payOffReal2";
        public const string topicDoubleCutShear1 = "DoubleCutShear1";
        public const string topicDoubleCutShear2 = "DoubleCutShear2";
        public const string topicNarrowWelder = "NarrowOverlapWelder";

        public const string prefixSteelCoil1 = "lengzhaProject.SteelCoil1.";
        public const string prefixSteelCoil2 = "lengzhaProject.SteelCoil2.";
        public const string prefixPayOffReal2 = "lengzhaProject.payOffReal2.";
        public const string prefixDoubleCutShear1 = "lengzhaProject.DoubleCutShear1.";
        public const string prefixDoubleCutShear2 = "lengzhaProject.DoubleCutShear2.";
        public const string prefixNarrowWelder = "lengzhaProject.NarrowOverlapWelder.";

        public bool getPointV()
        {
            return isStart;
        }
        public bool getPointV2()
        {
            return isStart2;
        }
        public Dictionary<string, dynamic> getCoilPointV()
        {
            return dic;
        }

        //实例化客户端
        public MqttClient mqttClient { get; set; }
        //单例模式
        public static MqttClientService Instance()
        {
            if (_instance == null)
            {
                lock (LockHelper)
                {
                    if (_instance == null)
                        _instance = new MqttClientService();
                }
            }
            return _instance;
        }

        //解析json文件
        //private void ParseUIPanelTypeJson()
        //{
        //    deviceTopicDict = new Dictionary<string, string>();

        //    //将json文件解析出来后，存放到字典中
        //    TextAsset textTopic = Resources.Load<TextAsset>("topic");

        //    DeviceTopicInfoList deviceTopicInfoList = JsonMapper.ToObject<DeviceTopicInfoList>(textTopic.text);

        //    foreach (DeviceTopicInfo deviceTopicInfo in deviceTopicInfoList.subDeviceTopic)
        //    {
        //        deviceTopicDict.Add(deviceTopicInfo.deviceName, deviceTopicInfo.topicName);
        //    }
        //}

        //根据设备名称查询对应的主题
        //public string getTopic(DeviceNameEnum deviceType)
        //{

        //    if (deviceTopicDict == null)
        //        return null;
        //    else
        //    {
        //        return deviceTopicDict[deviceType.ToString()].ToString();
        //    }
        //}

        //连接到broker服务器
        private MqttClientService()
        {
            EMQX_CLIENT_ID = Guid.NewGuid().ToString();
            //mqttClient = new MqttClient(EMQX_BROKER_IP, EMQX_BROKER_PORT, false, null);
            mqttClient = new MqttClient(IPAddress.Parse(EMQX_BROKER_IP));
            mqttClient.Connect(EMQX_CLIENT_ID, EMQX_USER_NAME, EMQX_PASSWORD);
            mqttClient.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;

            //ParseUIPanelTypeJson();
            ////订阅主题
            //string clientId = Guid.NewGuid().ToString();
            //mqttClient.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2 
            mqttClient.Subscribe(new string[] { "/L2/L2toCCS" }, new byte[] { qos }); 


           // subScribedTopic();

        }


        //订阅主题
        //public void subScribedTopic()
        //{
        //    foreach (DeviceNameEnum deviceName in Enum.GetValues(typeof(DeviceNameEnum)))
        //    {
        //        topics.Add(deviceTopicDict[deviceName.ToString()]);
        //    }

        //    //topics.Add(subTopic);
        //    //topics.Add(testTopic);
        //    //topics.Add(PayoffReelAndOutboardBearing._instance.topicMQTT);
        //    //topics.Add(CoilAndCoilCar._instance.topicMQTT);
        //    //topics.Add(DoubleCutShear._instance.topicMQTT);
        //    //topics.Add(NarrowOverlapWelder._instance.topicMQTT);
        //    //topics.Add(SideNotcher._instance.topicMQTT);

        //    //topics.Add(topicDoubleCutShear2);
        //    //topics.Add(topicSteelCoil2);
        //    //topics.Add(topicPayOffReal2);

        //    //直接获取解析json后的value值




        //    if (mqttClient != null && topics.Count > 0)
        //    {
        //        List<byte> qosList = new List<byte>();
        //        for (int i = 0; i < topics.Count; i++)
        //        {
        //            qosList.Add(qos);
        //        }
        //        mqttClient.Subscribe(topics.ToArray(), qosList.ToArray());
        //    }
        //}

        //发布主题
        public void publishTopic(string currentTopic, string content)
        {
            if (mqttClient != null && !string.IsNullOrEmpty(currentTopic) && !string.IsNullOrEmpty(content))
            {
                mqttClient.Publish(currentTopic, System.Text.Encoding.UTF8.GetBytes(content), qos, true);
            }
        }
        //断开连接
        public void unConnect()
        {
            if (mqttClient != null)
                mqttClient.Disconnect();
        }
        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (e.Topic.CompareTo(subTopic) == 0)
            {
                //receiveMsg = System.Text.Encoding.Default.GetString(e.Message);
                //JsonData jsonData = JsonMapper.ToObject(receiveMsg);
                //JsonData jsonValuesList = jsonData["values"];
                //vo = new ValuesVO();
                //foreach (JsonData item in jsonValuesList)
                //{
                //    vo.id = item["id"].ToString();
                //    vo.v = (bool)item["v"];
                //    vo.q = (bool)item["q"];
                //    vo.t = item["t"].ToString();
                //    if (vo.id == "lengzhaProject1.coil.isShow")
                //    {
                //        isStart = vo.v;
                //    }

                //    if (vo.id == "lengzhaProject1.coil.isShow2")
                //    {
                //        isStart2 = vo.v;
                //    }
                //}

            }
           
        }
    }
}
