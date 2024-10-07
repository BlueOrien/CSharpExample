using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        // 创建一个 ArrayList 实例
        ArrayList list = new ArrayList();
        #region 向 ArrayList 添加元素
        list.Add("Apple");
        list.Add(123);
        list.Add(3.14);
        list.Add(true);
        #endregion
        #region 遍历 ArrayList 中的元素并输出
        Console.WriteLine("Elements in ArrayList:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        #endregion
        #region 检查 ArrayList 中是否包含某个元素
        if (list.Contains("Apple"))
        {
            Console.WriteLine("ArrayList contains 'Apple'.");
        }
        #endregion
        #region 获取 ArrayList 的大小（元素个数）
        Console.WriteLine("Size of ArrayList: " + list.Count);
        #endregion
        #region 清空 ArrayList
        list.Clear();
        Console.WriteLine("Size of ArrayList after clearing: " + list.Count);
        #endregion
    }
}
