using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new SomeG();
            food.Bread();
            Console.ReadLine();
        }
    }

    public abstract class Food
    {
        public abstract void Bread();
    }

    public class Supermarket : Food
    {
        public override void Bread()
        {
            Console.WriteLine("购买一个面包");
        }
    }

    public class SomeG : Food
    {
        Supermarket sup;
        public override void Bread()
        {
            if (sup == null)
                sup = new Supermarket();
            Console.WriteLine("我给你买面包，可以。但");
            this.Money();
            Console.WriteLine("我去给你买面包了");
            sup.Bread();
        }
        public void Money()
        {
            Console.WriteLine("收取跑腿费");
        }
    }
}
