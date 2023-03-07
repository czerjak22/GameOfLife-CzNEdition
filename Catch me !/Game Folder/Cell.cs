using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_me__
{
    internal class Cell
    {
      
        bool isAlive;
        bool isAliveNext;
        List<Cell> szomszedok;

        public bool IsAlive { get => isAlive; set => isAlive = value; }
        public bool IsAliveNext { get => isAliveNext; set => isAliveNext = value; }
        internal List<Cell> Szomszedok { get => szomszedok; set => szomszedok = value; }


        // Live cells with fewer than two live neighbors die
        // Live cells with more than three live neighbors die
        // Dead cells with three live neighbors comes alive
        internal void check()
        {
            int seged = 0;
            foreach(Cell c in szomszedok)
            {
                if (c.IsAlive) seged++;

            }


            if(isAlive)
            {


                if( seged<2||seged>3)
                {
                    isAliveNext= false;
                }

                else
                {
                    isAliveNext= true;
                 }
            }
       
             else {
              if(  seged == 3)
                {
                    isAliveNext = true;
                }
                else
                {
                    isAliveNext = false;
                }
            }
        }

        public void update()
        {
            isAlive = isAliveNext;
        }


        public Cell() {

            isAlive = false;
            IsAliveNext = false;
          
            szomszedok = new List<Cell>();

        }
        public void Calculate()
        {
            int szAlive = 0;
            foreach (Cell szomszed in szomszedok)
            {
                if (szomszed.isAlive) szAlive++;
            }

            if (isAlive)
            {
                IsAliveNext = (szAlive == 2) || (szAlive == 3);
            }
            else
            {
                IsAliveNext = (szAlive == 3);
            }
            
        }

        public void Advance()
        {
            Calculate();
            isAlive = IsAliveNext;
        }

        
    }
}
