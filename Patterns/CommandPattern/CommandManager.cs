/**
 * 指令管理
 */

using System.Collections.Generic;

namespace GameBaseFramework.Patterns
{
    public class CommandManager
    {
        /// <summary>
        /// 指令链表
        /// </summary>
        private LinkedList<Command> _commandLinkedList = new LinkedList<Command>();
        /// <summary>
        /// 不需要实时实例化的指令集合
        /// </summary>
        private Dictionary<int, Command> _singleCommandDict = new Dictionary<int, Command>();

        /// <summary>
        /// 初始化
        /// </summary>
        protected virtual void Init()
        {
        }

        /// <summary>
        /// 添加指令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        public virtual void AddCommand<T>(T command) where T : Command
        {
        }

        /// <summary>
        /// 处理指令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        protected virtual void HandleCommand<T>(T command) where T : Command
        {
        }

        /// <summary>
        /// 更新指令
        /// </summary>
        public virtual void Update()
        {
        }
    }
}
