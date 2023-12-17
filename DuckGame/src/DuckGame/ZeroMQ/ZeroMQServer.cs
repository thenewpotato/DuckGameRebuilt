using NetMQ.Sockets;
using NetMQ;

namespace DuckGame
{
    class ZeroMQServer
    {
        private static ResponseSocket _server;

        static ZeroMQServer()
        {
            _server = new ResponseSocket();
            _server.Bind("tcp://*:5556");
        }

        public static string ReadFrame()
        {
            return _server.ReceiveFrameString();
        }

        public static void SendFrame(string msg)
        {
            _server.SendFrame(msg);
        }
    }
}
