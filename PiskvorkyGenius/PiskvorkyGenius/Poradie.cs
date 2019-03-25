using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PiskvorkyGenius
{
    class Poradie
    {
        public static Stack<Tah> poradie;

        public static void CreateStack()
        {
        poradie = new Stack<Tah>();
        }



        public static void AddStack(int lastmove, int rowIndex, int colIndex )
        {
            Tah novyTah = new Tah();
            novyTah.indexRiadka = rowIndex;
            novyTah.indexStlpca = colIndex;
            novyTah.lastmove = lastmove;

            poradie.Push(novyTah);
            Debug.WriteLine($"\nVložil som poradie\n{poradie.Peek().ToString()}");
        }

        public static Tah StepBack()
        {
            return poradie.Pop();
        }



    }
}
