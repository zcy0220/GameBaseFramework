/**
 * 事件管理
 */

using System;
using System.Collections.Generic;
using GameBaseFramework.Base;

namespace GameBaseFramework.Event
{
    public class EventManager
    {
        /// <summary>
        /// 回调绑定事件映射
        /// </summary>
        private Dictionary<int, List<object>> _handlerDict = new Dictionary<int, List<object>>();

        /// <summary>
        /// 添加监听事件
        /// </summary>
        public void AddListener<T>(Action<T> handler) where T : ITypeId
        {
            var typeId = TypeId.GetId<T>();
            if (_handlerDict.TryGetValue(typeId, out var list))
            {
                if (!list.Contains(handler))
                {
                    list.Add(handler);
                }
            }
            else
            {
                list = new List<object>() { handler };
                _handlerDict.Add(typeId, list);
            }
        }

        /// <summary>
        /// 删除监听
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handler"></param>
        public void RemoveListener<T>(Action<T> handler) where T : ITypeId
        {
            var typeId = TypeId.GetId<T>();
            if (_handlerDict.TryGetValue(typeId, out var list))
            {
                if (list.Contains(handler))
                {
                    list.Remove(handler);
                }
            }
        }

        /// <summary>
        /// 派发事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ev"></param>
        public void DispatchEvent<T>(T ev) where T : ITypeId
        {
            var typeId = TypeId.GetId<T>();
            if (_handlerDict.TryGetValue(typeId, out var list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    (list[i] as Action<T>).Invoke(ev);
                }
            }
        }
    }
}