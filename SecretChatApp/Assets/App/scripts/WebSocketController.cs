using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using WebSocketSharp;

public class WebSocketController : MonoBehaviour
{
    [SerializeField] string serverAddress = "";

    public static WebSocketController instance = null;

    public static WebSocketController Instance
    {
        get
        {
            return instance;
        }

    }

    private WebSocket webSocket = null;




    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        ConnectToServer();
    }


    public void ConnectToServer()
    {

        webSocket = new WebSocket(serverAddress);
        webSocket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;


        webSocket.OnOpen += OnOpen;
        webSocket.OnMessage += WebSocket_OnMessage;
        webSocket.OnClose += WebSocket_OnClose;
        webSocket.OnError += WebSocket_OnError;


        webSocket.Connect();

    }

   


    #region Websocket Events

    public void OnOpen(object sender, EventArgs e)
    {
        Debug.Log("Websocket opened");
    }

    private void WebSocket_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("Message received... Message: " + e.Data);
    }

    private void WebSocket_OnClose(object sender, CloseEventArgs e)
    {
        Debug.Log("Websocket close: " + e.Code + " Code " + e.Reason);
    }

    private void WebSocket_OnError(object sender, ErrorEventArgs e)
    {
        Debug.Log(e.Message);
    }


    #endregion


}
