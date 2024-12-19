using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day20___과제
{
    internal class BuffManager
    {
        LinkedList<Buff> buffManager = new LinkedList<Buff>();

        public void AddBuff(string name, int duration)
        {
            Buff buff = new Buff();
            buff.buffname = name;
            buff.buffduringtime = duration;
            buffManager.AddLast(buff);
        }

        public void UpdateBuffs()
        {
            var a = buffManager.First;


            while (a != null)
            {
                a.Value.buffduringtime--;
                if (a.Value.buffduringtime <= 0)
                {
                    buffManager.Remove(a);
                    Console.WriteLine("효과 종료");
                }
                a = a.Next;
            }

        }


        public void ShowActiveBuffs()
        {

            foreach (var ele in buffManager)
            {
                Console.Write(ele.buffname + " ");
                Console.WriteLine(ele.buffduringtime);

            }

        }








    }
}
