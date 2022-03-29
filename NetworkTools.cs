using System;
using System.Net.NetworkInformation;

namespace SocketHelper
{
    public class NetWorkTools
    {
        public static bool IsPingSuccess(string ipAddress, int timeOut)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ipAddress, timeOut);
            if (reply != null && reply.Status == IPStatus.Success)
                return true;
            else
                return false;
        }
    }
}
