using System;

namespace 抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("小明第一次跟女神约会");
            Console.WriteLine("由于小明是个小屌丝，所以他使用了恋爱管家APP帮助他制定的A计划");
            LoveManageApp app = new LoveManageA();
            Console.WriteLine("A计划开始");
            Console.WriteLine("我们先吃个饭吧");
            Eat eat = app.ReadEat();
            eat.GoEat();
            Console.WriteLine("我们看个电影吧");
            Movie mo = app.ReadMovie();
            mo.GoMovie();
            Console.WriteLine("我们嘿嘿嘿吧...........啪~~~...我擦真打啊..");
            Console.ReadLine();
        }
    }

    #region 抽象
    public abstract class LoveManageApp
    {
        public abstract Movie ReadMovie();
        public abstract Eat ReadEat();
    }

    public abstract class Movie
    {
        public abstract void GoMovie();
    }

    public abstract class Eat
    {
        public abstract void GoEat();
    }
    #endregion
    #region 实现
    public class LoveManageA : LoveManageApp
    {
        public override Eat ReadEat()
        {
            return new Mc();
        }

        public override Movie ReadMovie()
        {
            return new UMEMovie();
        }
    }
    public class LoveManageB : LoveManageApp
    {
        public override Eat ReadEat()
        {
            return new Kfc();
        }

        public override Movie ReadMovie()
        {
            return new WanDaMovie();
        }
    }
    public class UMEMovie : Movie
    {
        public override void GoMovie()
        {
            Console.WriteLine("出发去UME国际影城，看电影");
        }
    }
    public class WanDaMovie : Movie
    {
        public override void GoMovie()
        {
            Console.WriteLine("出发去万达国际影城，看电影");
        }
    }
    public class Mc : Eat
    {
        public override void GoEat()
        {
            Console.WriteLine("出发去麦当劳，吃饭");
        }
    }
    public class Kfc : Eat
    {
        public override void GoEat()
        {
            Console.WriteLine("出发去肯德基，吃饭");
        }
    }
    #endregion
}
