/**
 * 指令集
 */

using GameBaseFramework.Base;

namespace GameBaseFramework.Patterns
{
    /// <summary>
    /// 指令优先级
    /// </summary>
    public enum ECmdPriority
    {
        MinLevel     = -4,
        LowLevel1    = -3,
        LowLevel2    = -2,
        LowLevel3    = -1,
        DefaultLevel = 0,
        HighLevel1   = 1,
        HighLevel2   = 2,
        HighLevel3   = 3,
        MaxLevel     = 4,
    }

    /// <summary>
    /// 指令基类
    /// </summary>
    public abstract class Command : TypeId
    {
        /// <summary>
        /// 指令Id
        /// 同时代表添加的顺序
        /// </summary>
        public int Id;
        /// <summary>
        /// 指令优先级
        /// </summary>
        public ECmdPriority Priority;
    }
}
