## GameBaseFramework.Base
* DataValue：数据驱动
```sh
/**
 * 代码示例
 */
var obj = new DataValue<int>(0);
obj.Set(10);
obj += (value) =>
{
    // value = 10
};
```