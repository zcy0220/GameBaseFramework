/**
 * 帧指令
 * 所有帧同步操作抽象为【关键字+通用参数】的命令形式
 */

namespace GameFramework.Net.FrameSync
{
    public class FrameSyncCommand
    {
        /// <summary>
        /// 关键字
        /// 输入操作：虚拟按键
        /// 指令操作：FrameSyncVKey映射的命令
        /// </summary>
        public int Key;
        /// <summary>
        /// 通用参数1
        /// </summary>
        public int Param1;
        /// <summary>
        /// 通用参数2
        /// </summary>
        public int Param2;
    }
}
