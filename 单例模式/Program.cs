using System;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Suitors su = new Suitors();
            su.Go();
            Console.ReadLine();
        }
    }

    public class Suitors {
        public async void Go() {
            Task xm = xiaoMing();
            Task xg = xiaoGang();
            await xm;
            await xg;
        }

        public async Task xiaoMing()
        {
            await Task.Delay(1000);
            Goddess girl =Goddess.HelloGoddess();
        }

        public async Task xiaoGang()
        {
            await Task.Delay(1000);
            Goddess girl =Goddess.HelloGoddess();
        }
    }

    public class Goddess
    {
        private Goddess() { Console.WriteLine("我有空，走吧"); }
        private static Goddess _Goddess;
        private static object obj = new object();
        //创建全局访问点
        public static Goddess HelloGoddess() {
            if (_Goddess == null)
            {
                 lock(obj)
                {
                    if(_Goddess == null)
                        _Goddess = new Goddess();
                    else
                    {
                        Console.WriteLine("很抱歉，我没有时间");
                    }
                }
            }
            else
            {
                Console.WriteLine("很抱歉，我没有时间");
            }
            return _Goddess;
        }
    }
}
