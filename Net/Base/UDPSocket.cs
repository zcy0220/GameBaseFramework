using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace GameFramework.Net
{
    public class UDPSocket : ISocket
    {
        /// <summary>
        /// 系统socket
        /// </summary>
        private Socket _systemSocket;

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="size"></param>
        /// <param name="remoteEP"></param>
        /// <returns></returns>
        public int SendTo(byte[] buffer, int size, IPEndPoint remoteEP)
        {
            return _systemSocket.SendTo(buffer, 0, size, SocketFlags.None, remoteEP);
        }
    }
}