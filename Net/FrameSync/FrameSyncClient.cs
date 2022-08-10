/**
 * 帧同步客户端
 */

using System.Net;

namespace GameFramework.Net.FrameSync
{
    public class FrameSyncClient
    {
        #region 通信模块
        /// <summary>
        /// Socket
        /// 暂时用UDP，之后用KCP替换
        /// </summary>
        private ISocket _socket;
        /// <summary>
        /// 主机地址
        /// </summary>
        private string _host;
        /// <summary>
        /// 端口
        /// </summary>
        private int _port;
        /// <summary>
        /// host对应的IPEndPoint
        /// </summary>
        private IPEndPoint _hostEndPoint;
        #endregion
        /// <summary>
        /// 是否连接
        /// </summary>
        private bool _isRunning = false;

        /// <summary>
        /// 发送帧同步指令
        /// </summary>
        /// <param name="vkey"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public bool SendFrameSyncCommand(int vkey, int param1, int param2)
        {
            //if (_isRunning)
            //{
            //    var cmd = m_TempSendData.vkeys[0];
            //    cmd.vkey = vkey;
            //    cmd.args = new int[] { arg };

            //    int len = PBSerializer.NSerialize(m_TempSendData, m_TempSendBuf);

            //    return m_Socket.SendTo(m_TempSendBuf, len, m_HostEndPoint);
            //}
            return false;
        }
    }
}