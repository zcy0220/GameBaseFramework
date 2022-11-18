/**
 * 本地作为服务器的管理
 */

namespace GameBaseFramework.Networks
{
    public class ServerNetManager
    {
        /// <summary>
        /// Gateway
        /// </summary>
        private IGateway _gateway;

        /// <summary>
        /// 构造初始化
        /// </summary>
        /// <param name="connectionType"></param>
        /// <param name="port"></param>
        public ServerNetManager(EConnectionType connectionType, int port = 0)
        {
            if (connectionType == EConnectionType.UDP)
            {
                _gateway = new UDPGateway(port, NetConfig.PacketBufferSize);
            }
        }

        /// <summary>
        /// 清理
        /// </summary>
        public void Close()
        {
            if (_gateway != null)
            {
                _gateway.Close();
                _gateway = null;
            }
        }

        /// <summary>
        /// 日志输出
        /// </summary>
        public void Dump()
        {
            if (_gateway != null)
            {
                _gateway.Dump();
            }
        }

        /// <summary>
        /// Tick
        /// </summary>
        public void Tick()
        {
            if (_gateway != null)
            {
                _gateway.Tick();
            }
        }
    }
}
