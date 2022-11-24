using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поликлиника
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people;
            int timeOne = 10;
            int waitingTime;
            Console.Write(" Введите кол-во людей ");
            people = Convert.ToInt32(Console.ReadLine());
            waitingTime = people * timeOne;
            Console.WriteLine(" Вы должны отсоять в очереди " + waitingTime / 60 + " часов " + waitingTime % 60 + " минут ");
        }
    }
}
