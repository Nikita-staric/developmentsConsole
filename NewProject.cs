using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //екземпрял Класса
            classLogic class__Logic = new classLogic();
            checkingEvent checking__Event = new checkingEvent();
            checkingEvent1 checking___Event = new checkingEvent1();
            //Подписались на событие
            class__Logic.delegaate += checking__Event.outputCompletedCompleted;
            class__Logic.delegaate += checking___Event.outputCompletedCompleted1;
            //Запустили счетчик
            class__Logic.counter();

        }
    }
   // public delegate void Cc();
    class classLogic
    {
        public delegate void NewDelegate();
        public event NewDelegate delegaate;
      //  public delegate void Cc();
      
      
        public  void counter()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {

                    Console.WriteLine("71");
                    delegaate();
                    Console.ReadLine();
                }
                else
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.WriteLine("71");
                        delegaate();
                        int vv = 0;
                        Console.WriteLine($"{j}", vv++);
                    }





                }
            }

        }
       
    }
    class checkingEvent
    {
        public void outputCompletedCompleted()
        {
            Console.WriteLine("event output 71");
        }
    }
    class checkingEvent1
    {
        public void outputCompletedCompleted1()
        {
            Console.WriteLine("there will definitely be a conclusion here");
        }
    }
}
