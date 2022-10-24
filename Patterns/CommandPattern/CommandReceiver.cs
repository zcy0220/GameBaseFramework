/**
 * 指令接受器
 */

using GameBaseFramework.Base;

namespace GameBaseFramework.Patterns
{
    public class CommandReceiver : ITypeId
    {
        /// <summary>
        /// 执行指令
        /// </summary>
        public virtual void Execute(Command command) { }
    }
}
