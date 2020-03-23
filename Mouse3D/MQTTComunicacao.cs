using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Mouse3D
{
    class MQTTComunicacao
    {
        public event Form1.ChangedEventHandle Received;

        private static IManagedMqttClient client;

        public void ConnectAsync(string topic,string url,int porta,string usuario,string senha)
        {
            string clientId = Guid.NewGuid().ToString();
            string mqttURI = url;// "192.168.0.10";//       // { MQTT SERVER URI }
            int mqttPort = porta;// 1883;          // { MQTT PORT }
            string mqttUser = usuario;// "admin";// ServicoMQTT.Rootparam.Parametros.Node.User;        // { MQTT USER }
            string mqttPassword = senha;// "12345";// ServicoMQTT.Rootparam.Parametros.Node.Passwd;  // { MQTT PASSWORD }
            //
            bool mqttSecure = false;// ServicoMQTT.Rootparam.Parametros.Node.UsingSSL;    // { IF YOU ARE USING SSL Port THEN SET true OTHERWISE SET false }
            //
            var messageBuilder = new MqttClientOptionsBuilder()
                .WithClientId(clientId)
                .WithCredentials(mqttUser, mqttPassword)
                .WithTcpServer(mqttURI, mqttPort)
                .WithCleanSession();
            //
            var options = mqttSecure
                ? messageBuilder
                .WithTls()
                .Build()
                : messageBuilder
                .Build();
            //
            var managedOptions = new ManagedMqttClientOptionsBuilder()
              .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
              .WithClientOptions(options)
              .Build();
            //
            client = new MqttFactory().CreateManagedMqttClient();
            client.StartAsync(managedOptions).GetAwaiter().GetResult();
            
            //
            if (!string.IsNullOrEmpty(topic))
            {
                client.SubscribeAsync(topic).GetAwaiter().GetResult();
                Log("ConnectAsync", "Aguardando Mensagem");
            }
            else
            {
                Log("ConnectAsync", "Nome do tópico não especificado");
            }
            //
            client.UseConnectedHandler(e =>
            {
                Log("UseConnectedHandler", "Conectado com sucesso com os MQTT Brokers.");
            });
            //
            client.UseDisconnectedHandler(e =>
            {
                Log("UseDisconnectedHandler", "Disconectado do MQTT Brokers.");
            });
            //
            client.UseApplicationMessageReceivedHandler(e =>
            {
                onReceived(e);
            });
        }

        protected virtual void onReceived(MqttApplicationMessageReceivedEventArgs e)
        {
            string timestamp = "";
            string payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            // verifica se no dado recebido tem | vertical tab e remove
            if (payload.Contains(@"|"))
            {
                timestamp = payload.Substring(0, payload.LastIndexOf(@"|") - 1);
                payload = payload.Substring(payload.LastIndexOf(@"|") + 1);
            }
            //
            string intopic = e.ApplicationMessage.Topic;
            //
            if (string.IsNullOrWhiteSpace(e.ApplicationMessage.Topic) == false)
            {
                var t = payload;
                //// Quebra o topico \ para pegar o ID e o Valor recebido
                //String[] inTopic = Regex.Split(e.ApplicationMessage.Topic, @"/");
                ////
                //if (inTopic[3].Length == 0 || inTopic[4].Length == 0)
                //    Log("ConnectAsync", $"Desprezados topico : {intopic} e Payload {payload}");
                //else
                //{
                //    Log("ConnectAsync", $"Recebido topico : {intopic} e Payload {payload}");
               // Received("", "", payload, timestamp);
                //}
            }
            else
            {
                Log("ConnectAsync", "Nome do tópico não especificado");
                Log("UseApplicationMessageReceivedHandler", $"Messagem Recebida Sem Topico: {payload}");
            }
        }

        /// <summary>
        /// Subscribe topic.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <param name="qos">Quality of Service.</param>
        /// <returns>Task.</returns>
        private async Task<bool> SubscribeAsync(string topic, int qos = 0)
        {
            await client.SubscribeAsync(new TopicFilterBuilder()
                .WithTopic(topic)
                .WithQualityOfServiceLevel((MQTTnet.Protocol.MqttQualityOfServiceLevel)qos)
                .Build());
            //
            return true;
        }

        public async Task<bool> Publish(string channel, string value)
        {
            //var factory = new MqttFactory();
            //var mqttClient = factory.CreateMqttClient();

            ////if (mqttClient.IsConnected == false)
            ////{
            ////    //Debug.WriteLine("publishing failed");
            ////    return false;
            ////}

            //var message = new MqttApplicationMessageBuilder()
            //        .WithTopic(channel)
            //        .WithPayload(value)
            //        .WithExactlyOnceQoS()
            //        .WithRetainFlag()
            //        .Build();
            //await mqttClient.PublishAsync(message);

            await client.PublishAsync(new MqttApplicationMessageBuilder()
            .WithTopic(channel)
            .WithPayload(value)
            .WithQualityOfServiceLevel((MQTTnet.Protocol.MqttQualityOfServiceLevel)1)
            .WithRetainFlag(false)
            .Build());

            return true;
        }
        public static void Log(string origem, string Message)
        {

        }
    }
}
