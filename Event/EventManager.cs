/**
 * 事件管理
 */

using System;
using System.Collections.Generic;

namespace GameFramework.Event
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
        public void AddListener<T>(Action<T> handler) where T : BaseEvent
        {
            //var typeId = T.GetType();
            //if (_handlerDict.TryGetValue())
        }
    }
}