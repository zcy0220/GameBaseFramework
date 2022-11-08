/**
 * 指令接受器
 */

using System;
using GameBaseFramework.Base;
using System.Collections.Generic;

namespace GameBaseFramework.Patterns
{
    public class CommandReceiver : ITypeId
    {
        /// <summary>
        /// 指令回调集合
        /// </summary>
        protected Dictionary<int, object> _commandHandlerDict = new Dictionary<int, object>();

        /// <summary>
        /// 绑定回调
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handler"></param>
        protected void Bind<T>(Action<T> handler) where T : Command
        {
            var commandTypeId = TypeId.GetId<T>();
            if (!_commandHandlerDict.ContainsKey(commandTypeId))
            {
                _commandHandlerDict.Add(commandTypeId, handler);
            }
        }

        /// <summary>
        /// 解绑回调
        /// </summary>
        /// <typeparam name="T"></typeparam>
        protected void Unbind<T>() where T : Command
        {
            var commandTypeId = TypeId.GetId<T>();
            if (_commandHandlerDict.ContainsKey(commandTypeId))
            {
                _commandHandlerDict.Remove(commandTypeId);
            }
        }

        /// <summary>
        /// 执行指令
        /// </summary>
        public void Execute<T>(T command) where T : Command
        {
            var commandTypeId = TypeId.GetId<T>();
            if (_commandHandlerDict.ContainsKey(commandTypeId))
            {
                var handler = _commandHandlerDict[commandTypeId] as Action<T>;
                handler.Invoke(command);
            }
        }
    }
}
