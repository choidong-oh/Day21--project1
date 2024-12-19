using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20___과제
{
    internal class Marine : TerranUnit
    {
        public Marine()
        {
            attackAvail = true;

        } 
        public void Stimpak()
        {
            terranHp -= 10;
            Console.WriteLine("공속, 뎀지 일시 상승");




        }





    }
}
