/**
 * 将KCP与Socket封装在一起，以提供可靠UDP通讯功能
 * 参考:https://github.com/slicol/SGF
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace GameBaseFramework.Networks
{
    public class KCPSocket
    {



        #region 时钟
        private static readonly DateTime UTCStartTime = new DateTime(1970, 1, 1);
        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        public static UInt32 GetClockMS()
        {
            return (UInt32)(Convert.ToInt64(DateTime.UtcNow.Subtract(UTCStartTime).TotalMilliseconds) & 0xffffffff);
        }
        #endregion
    }
}
