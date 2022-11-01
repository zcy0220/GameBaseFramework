/**
 * 网络管理模块
 */

using GameBaseFramework.Base;

namespace GameBaseFramework.Networks
{
    public class NetManager
    {
        /// <summary>
        /// 当前连接
        /// </summary>
        private Connection _connection;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="connectionType"></param>
        /// <param name="localPort"></param>
        public NetManager(EConnectionType connectionType, int localPort = 0)
        {
            Debuger.Log($"connectionType:{connectionType}, localPort:{localPort}");
        }
    }
}
