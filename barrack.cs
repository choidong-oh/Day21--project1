using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20___과제
{
    internal class barrack
    {
        public Queue<TerranUnit> queue = new Queue<TerranUnit>();
        public TerranUnit te;
        TerranUnit te1;



        public Marine Marine = new Marine();
        public medic medic = new medic();




        public void EnqueueUnit(TerranUnit unit, string name, int health)
        {
            te = unit;

            te.terranName = name;
            te.terranHp = health;
            queue.Enqueue(te);
            if(queue.Count== 0)
            {
                Console.WriteLine("dd");
            }
            Console.WriteLine($"{te} {te.terranName} 출력");



        }
        public void DequeueUnit()
        {
            Console.WriteLine("첫번째 : " + queue.First().terranName);
        }

        public void ShowQueueLine()
        {
            foreach(var ele in queue)
            {
                Console.WriteLine("이름 : " + ele.terranName);
            }
            



        }






    }
}
