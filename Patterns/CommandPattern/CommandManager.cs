/**
 * 指令管理
 */

using System.Collections.Generic;
using GameBaseFramework.Base;

namespace GameBaseFramework.Patterns
{
    public class CommandManager
    {
        /// <summary>
        /// 指令链表
        /// </summary>
        private LinkedList<Command> _commandLinkedList = new LinkedList<Command>();
        /// <summary>
        /// 指令接受器集合
        /// command -> receiver
        /// </summary>
        private Dictionary<int, CommandReceiver> _commandReceiverDict = new Dictionary<int, CommandReceiver>();
        /// <summary>
        /// 指令唯一索引
        /// </summary>
        private static int _uniqueIndex = 0;

        /// <summary>
        /// 添加指令接受器
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="commandReceiver"></param>
        protected virtual void BindCommandReceiver<T>(CommandReceiver commandReceiver) where T : Command
        {
            var commandTypeId = TypeId.GetId<T>();
            _commandReceiverDict.Add(commandTypeId, commandReceiver);
        }

        /// <summary>
        /// 添加指令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        public virtual void AddCommand<T>(T command) where T : Command
        {
            if (command.SyncExecute)
            {
                HandleCommand(command);
            }
            else
            {
                command.Index = ++_uniqueIndex;
                var current = _commandLinkedList.First;
                while(current != null)
                {
                    if ((int)current.Value.Priority < (int)command.Priority)
                    {
                        _commandLinkedList.AddBefore(current, command);
                        return;
                    }
                    current = current.Next;
                }
                _commandLinkedList.AddLast(command);
            }
        }

        /// <summary>
        /// 处理指令
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        protected virtual void HandleCommand<T>(T command) where T : Command
        {
            var commandTypeId = TypeId.GetId<T>();
            if (_commandReceiverDict.TryGetValue(commandTypeId, out var commandReceiver))
            {
                commandReceiver.Execute(command);
            }
        }

        /// <summary>
        /// 更新指令
        /// </summary>
        public virtual void Update()
        {
            if (_commandLinkedList.Count > 0)
            {
                foreach(var command in _commandLinkedList)
                {
                    HandleCommand(command);
                }
                _commandLinkedList.Clear();
            }
        }
    }
}
