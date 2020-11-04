using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class NewBehaviourScript : MonoBehaviour
{
    public byte[] data = new byte[1024];
    public IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 44444);
    private IPEndPoint ip;
    private UdpClient udpClient;

    void Start()
    {
        ip = new IPEndPoint(IPAddress.Any, 44444);
        udpClient = new UdpClient(ipep);
    }

    void Update()
    {
        Data();
    }

    public byte[] Data()
    {
        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);

        while (true)
        {
            data = udpClient.Receive(ref sender);
            System.Console.WriteLine(Encoding.ASCII.GetString(data, 0, data.Length));
        }
    }
}
