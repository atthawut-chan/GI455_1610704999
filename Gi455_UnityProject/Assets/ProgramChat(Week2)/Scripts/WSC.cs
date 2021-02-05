using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;

namespace ProgramChat
{
    public class WSC : MonoBehaviour
    {
        private WebSocket websocket;
        public GameObject inputIp;
        public GameObject inputPort;
        public GameObject LoginWindow;
        public GameObject ChatBox;
        public Text ChatText;
        public Text MyChatText;
        public GameObject userInput;
        // Start is called before the first frame update
        void Start()
        {
            //websocket = new WebSocket("ws://" + inputField.GetComponent<Text>().text + ":" + inputPort.GetComponent<Text>().text);

            //websocket.OnMessage += OnMessage;

            //websocket.Connect();

            //websocket.Send("I'm coming here.");
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.Return))
            //{
            //    //if(websocket.ReadyState == WebSocketState.Open)
            //    //{
            //    //    websocket.Send("" + inputField.GetComponent<InputField>().text);
            //    //}
            //}
        }
        private void OnDestroy()
        {
            if(websocket != null)
            {
                websocket.Close();
            }
        }

        public void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            ChatText.text += "" + messageEventArgs.Data + "\n";
            Debug.Log("Receive msg : " + messageEventArgs.Data);
            
        }

        public void LogIn()
        {
            websocket = new WebSocket("ws://" + inputIp.GetComponent<Text>().text + ":" + inputPort.GetComponent<Text>().text);

            websocket.OnMessage += OnMessage;

            websocket.Connect();

            LoginWindow.SetActive(false);

            ChatBox.SetActive(true);
        }

        public void Sender()
        {
            if (websocket.ReadyState == WebSocketState.Open)
            {
                websocket.Send("" + userInput.GetComponent<InputField>().text);
            }
        }
    }
}

