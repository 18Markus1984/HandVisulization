using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class NewBehaviourScript : MonoBehaviour
{
    private TcpListener server;
    private StreamReader reader;    

    void Start()
    {
        server = new TcpListener(IPAddress.Parse("192.188.4.10"), 1338);
        server.Start();
        new Thread(() => {
            TcpClient client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream()
            reader = new StreamReader(stream);
        }).Start();
    }

    void Update()
    {
        Data();
    }

    public string GetData()
    {
        return reader.ReadLine();
    }
}
