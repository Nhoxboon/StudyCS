﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Buoi5
    {
        int x,y;
        public Buoi5() { }
        public Buoi5 (int x, int y) 
        {
            this.x = x;
            this.y = y;
        } 
        
        public void HoanVi(out int x, out int y) 
        {
            /*this.x = x;
            this.y = y;*/
            x = 6; y = 7;
            int temp = x;
            x = y;
            y = temp;
        }
        
        public void PTin(in float a)
        {
            //a++;
            Console.WriteLine(a);
        }

    }
}
