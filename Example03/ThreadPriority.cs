using System;
#region 线程的优先级实现原理说明
//线程的优先级并不是先执行哪个后执行哪个
//所有的线程不论优先级高低都会同时执行,
//优先级越高表示CPU分配给该线程的时间片越多, 执行时间就多
//优先级越低表示CPU分配给该线程的时间片越少, 执行时间就少
#endregion
class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(new ThreadStart(Thread1));  //使用自定义方法Thread1声明线程
        thread1.Priority = ThreadPriority.Lowest;               //设置线程的调度优先级
        Thread thread2 = new Thread(new ThreadStart(Thread2));  //使用自定义方法Thread2声明线程
        thread1.Start();                                        //开启线程一
        thread2.Start();                                        //开启线程二
        Console.ReadLine();
    }
    static void Thread1()
    {
        Console.WriteLine("Thread1");
    }
    static void Thread2()
    {
        Console.WriteLine("Thread2");
    }
}