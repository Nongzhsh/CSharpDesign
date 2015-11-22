using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMing m = new SomeMing();
            m.Speak("隔壁班级的女神王小花过生日了。");
            m.Speak("我想追求她，不能放过这次机会。但是直接表白，我又怕被拒绝");
            m.Speak("所以我带她去味多美，请她吃一次蛋糕。她心情好说不定就同意了呢");
            m.Speak("小花，我们去味多美吃蛋糕吧");
            m.BuyCake();
            Console.ReadLine();
        }
    }

    public class SomeMing
    {
        //讲话
        public void Speak(string strText)
        {
            Console.WriteLine("小明说：" + strText);
        }
        //买蛋糕
        public void BuyCake()
        {
            Cake cake = WeiDuoMei.Buy("BlackForest");
            cake.Eat();
        }
    }

    public class WeiDuoMei
    {
        public static Cake Buy(string strCakeType)
        {
            Cake cake = null;
            if (strCakeType.Equals("BlackForest"))
            {
                cake = new BlackForestCake();
            }
            if (strCakeType.Equals("Angle"))
            {
                cake = new AngleCake();
            }
            return cake;
        }
    }

    public abstract class Cake
    {
        public abstract void Eat();
    }

    public class BlackForestCake : Cake
    {
        public override void Eat()
        {
            Console.WriteLine("很好吃，我很喜欢黑森林蛋糕");
        }
    }

    public class AngleCake : Cake
    {
        public override void Eat()
        {
            Console.WriteLine("很好吃，我很喜欢天使蛋糕");
        }
    }
}
