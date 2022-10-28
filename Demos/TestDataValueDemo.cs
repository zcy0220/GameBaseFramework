/**
 * 数据驱动测试
 */

using GameBaseFramework.Base;

namespace GameBaseFramework.Demos
{
    internal class TestDataValueDemo
    {
        private DataValue<int> _watchValue = new DataValue<int>(0);

        public void Main()
        {
            _watchValue += OnValueChange;

            //改变数据 驱动监听
            _watchValue.Set(10);
            _watchValue.Set(100);
        }

        private void OnValueChange(int value)
        {
            // value = 10
            // value = 100
        }

        private void Destroy()
        {
            _watchValue -= OnValueChange;
        }
    }
}
