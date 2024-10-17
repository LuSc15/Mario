using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mario
{
    public class SmallMario : IState
    {
         IState IState.GetState()
        {
            return this;
            
        }

        public void GotFeather(Mario m)
        {
            m.SetState(new CapeMario());
            Console.WriteLine($"Kleiner Mario hat Feder eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(300);
            Console.WriteLine();
        }

        public void GotFireflower(Mario m)
        {
            m.SetState(new FireMario());
            Console.WriteLine($"Kleiner Mario hat Feuerblume eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(200);
            Console.WriteLine();
        }

        public void GotMushroom(Mario m)
        {
            m.SetState(new SuperMario());
            Console.WriteLine($"Kleiner Mario hat Pilz eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(100);
            Console.WriteLine();
        }

        public void MetMonster(Mario m)
        {
            Console.WriteLine($"{m.GetState().GetType().Name} wurde von einem Gegner getroffen und hat ein Leben verloren.");

            m.lifeLost();
           
        }
    }
}