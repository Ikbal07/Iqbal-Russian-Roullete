using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iqbal_russian
{
    class GameRoullete
    {
        public int spinstr;
        public int bulleteshotwaya = 2;
        public int leftchamber = 6;
        public int Russianspin(int Roullete)
        {
            if (Roullete == 6)
            {
                Roullete = 1;
            }
            else
            {
                Roullete++;
            }
            return Roullete;
        }
        public int AwaybulleteMissed()
        {
            int Track = 0;
            if (leftchamber > 0 && spinstr == 1 && bulleteshotwaya == 2)
            {

                Track = 10;


            }
            if (leftchamber > 0 && spinstr == 1 && bulleteshotwaya == 1)
            {

                Track = 5;

            }

            else if (leftchamber > 0 && spinstr != 1)
            {
                Track = 0;
                leftchamber = leftchamber - 1;
                spinstr = Russianspin(spinstr);



            }
            return Track;
        }
    }
}
