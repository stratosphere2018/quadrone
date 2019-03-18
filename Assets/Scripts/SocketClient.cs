using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

namespace Stratosphere.Quadrone
{
    public class SocketClient : MonoBehaviour
    {
        private WebSocket ws;

        // Start is called before the first frame update
        void Start()
        {
            ws = new WebSocket(Secret.WSS);
            ws.OnMessage += (sender, e) =>
            {
                Debug.Log(e.Data);
            };
            ws.Connect();
        }

        // Update is called once per frame
        void Update()
        {
            if (InputExt.GetButton00Press())
            {
                ws.Send("test");
            }
        }
    }
}
