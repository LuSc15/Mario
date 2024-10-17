using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mario
{
    public class CapeMario : IState
    {
        public IState GetState()
        {
            return new CapeMario();
        }

        public void GotFeather(Mario m)
        {
            m.SetState(new CapeMario());
            Console.WriteLine($"CapeMario hat Feder eingesammelt und bleibt {m.GetState().GetType().Name}");
            m.CoinsAdd(300);
            Console.WriteLine();
        }


        public void GotFireflower(Mario m)
        {
            m.SetState(new FireMario());
            Console.WriteLine($"CapeMario hat Feuerblume eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(200);
            Console.WriteLine();
        }

 

        public void GotMushroom(Mario m)
        {
            Console.WriteLine($"CapeMario hat Pilz eingesammelt und bleibt {m.GetState().GetType().Name}");
            m.CoinsAdd(100);
            Console.WriteLine();
        }

        public void MetMonster(Mario m)
        {
            Console.WriteLine($"{m.GetState().GetType().Name} wurde von einem Gegner getroffen und in SmallMario zurückverwandelt.");

            m.SetState(new SmallMario());
        }


    }
}