/**
 * 会话接口定义
 */

using System.Net;

namespace GameBaseFramework.Networks
{
    public interface ISessionListener
    {
        /// <summary>
        /// 接收协议消息
        /// </summary>
        /// <param name="session"></param>
        /// <param name="msg"></param>
        public void OnReceive(Session session, ProtoMessage message);
        /// <summary>
        /// 断开指定Session
        /// </summary>
        /// <param name="session"></param>
        public void OnDisconnected(Session session);
    }

    public class Session
    {
        /// <summary>
        /// Token
        /// </summary>
        public uint AuthToken { get; set; }
        /// <summary>
        /// SessionId
        /// </summary>
        public uint Id { get; }
        /// <summary>
        /// 连接是否被激活
        /// </summary>
        public bool IsActived { get; }
        /// <summary>
        /// 连接的Ping值
        /// </summary>
        public ushort Ping { get; set; }
        /// <summary>
        /// 初始化成功后，可以获取本地EndPoint
        /// </summary>
        public IPEndPoint LocalEndPoint { get; }
        /// <summary>
        /// 连接建立后，可以获取远端EndPoint
        /// </summary>
        public IPEndPoint RemoteEndPoint { get; }
        /// <summary>
        /// 数据发送
        /// 有可能是同步模式
        /// 也可能是异步模式
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public virtual bool Send(ProtoMessage message) { return false; }
        /// <summary>
        /// Tick
        /// </summary>
        /// <param name="currentMS"></param>
        public virtual void Tick(int currentMS) { }
    }
}
