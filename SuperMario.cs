using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mario
{
    public class SuperMario : IState
    {
        public IState GetState()
        {
            throw new NotImplementedException();
        }

        public void GotFeather(Mario m)
        {
            m.SetState(new CapeMario());
            Console.WriteLine($"SuperMario hat Feder eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(300);
            Console.WriteLine();

        }

        public void GotFireflower(Mario m)
        {
            m.SetState(new FireMario());
           
            Console.WriteLine($"SuperMario hat Feuerblume eingesammelt und ist nun {m.GetState().GetType().Name}");
            m.CoinsAdd(200);
            Console.WriteLine();
            
        }

        public void GotMushroom(Mario m)
        {
            Console.WriteLine($"Super Mario hat Pilz eingesammelt und bleibt {m.GetState().GetType().Name}");
            m.CoinsAdd(100); 
            Console.WriteLine();
        }

        public void MetMonster(Mario m)
        {
           Console.WriteLine($"{m.GetState().GetType().Name} wurde von einem Gegner getroffen und in SmallMario zurückverwandelt.");
            Console.WriteLine();
            m.SetState(new SmallMario());
        }
    }
}