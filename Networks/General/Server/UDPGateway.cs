/**
 * UDPGateway
 * 可优化点：1.SocketAsyncEventArgs用对象池封装
 */

using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using GameBaseFramework.Base;

namespace GameBaseFramework.Networks
{
    public class UDPGateway : IGateway
    {
        /// <summary>
        /// 端口
        /// </summary>
        private int _port;
        /// <summary>
        /// 运行状态控制
        /// </summary>
        private bool _isRunning = false;
        /// <summary>
        /// 接收缓存写入器
        /// </summary>
        private NetBufferWriter _receiveBufferWriter;
        /// <summary>
        /// Session List的映射
        /// </summary>
        private Dictionary<uint, List<Session>> _sessionListDict;
        /// <summary>
        /// 接收Socket相关
        /// </summary>
        private Socket _socket = null;
        private SocketAsyncEventArgs _receiver = null;

        /// <summary>
        /// 本地IP
        /// </summary>
        public IPEndPoint LocalEndPoint { get; private set; }

        /// <summary>
        /// 初始化构造
        /// </summary>
        /// <param name="port"></param>
        /// <param name="listener"></param>
        public UDPGateway(int port, int bufferSize)
        {
            _port = port;
            _isRunning = true;
            _receiveBufferWriter = new NetBufferWriter();
            //m_listener = listener;
            _sessionListDict = new Dictionary<uint, List<Session>>();
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(new IPEndPoint(IPAddress.Any, _port));
            LocalEndPoint = _socket.LocalEndPoint as IPEndPoint;
            _port = LocalEndPoint.Port;
            _receiver = new SocketAsyncEventArgs();
            _receiver.SetBuffer(new byte[bufferSize], 0, bufferSize);
            _receiver.Completed += OnReceiveCompleted;
            _receiver.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            ReceiveAsync();
        }

        /// <summary>
        /// 异步接收
        /// </summary>
        private void ReceiveAsync()
        {
            if (_socket == null)
            {
                return;
            }

            bool result = true;
            try
            {
                result = _socket.ReceiveFromAsync(_receiver);
            }
            catch (Exception e)
            {
                Debuger.LogError(e.Message);
            }

            if (!result)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(_ => OnReceiveCompleted(this, _receiver));
            }
        }

        /// <summary>
        /// 接收完成回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReceiveCompleted(object sender, SocketAsyncEventArgs e)
        {

        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Dump()
        {
            throw new System.NotImplementedException();
        }

        public void Tick()
        {
            throw new System.NotImplementedException();
        }
    }
}
