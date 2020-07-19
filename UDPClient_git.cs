using UnityEngine;
using System.Net.Sockets;
using System.Text;

public class UDPClient : MonoBehaviour
{
    // broadcast address
    public string host = "*********";
    public int port = 10000;
    private UdpClient client;

    void Start()
    {
        client = new UdpClient();
        client.Connect(host, port);
    }

    void Update()
    {
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(170, 400, 740, 260), "Send_1"))
        {
            byte[] dgram = Encoding.UTF8.GetBytes("1");
            client.Send(dgram, dgram.Length);
        }
        if (GUI.Button(new Rect(170, 780, 740, 260), "Send_2"))
        {
            byte[] dgram = Encoding.UTF8.GetBytes("2");
            client.Send(dgram, dgram.Length);
        }
        if (GUI.Button(new Rect(170, 1160, 740, 260), "Send_3"))
        {
            byte[] dgram = Encoding.UTF8.GetBytes("3");
            client.Send(dgram, dgram.Length);
        }
    }

    void OnApplicationQuit()
    {
        client.Close();
    }
}