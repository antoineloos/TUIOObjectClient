﻿using ObjetTangibleTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                var lst = CltSingleton.Instance.clt.getTuioObjects();
                if (lst != null)
                {

                    foreach (TUIO.TuioObject tmp in CltSingleton.Instance.clt.getTuioObjects())
                    {
                        
                        Console.WriteLine("ID : " + tmp.SymbolID.ToString() + " PosX : " + tmp.Position.X.ToString() + " PosY : " + tmp.Position.Y.ToString() + " Angle : " + tmp.AngleDegrees.ToString());
                        Console.WriteLine(lst.Count.ToString());
                    }


                }
                else Console.Clear();
              
            }
        }
    }
}
