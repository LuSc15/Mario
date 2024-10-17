using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mario
{
    public interface IState
    {
        void GotMushroom(Mario m);
        void GotFireflower(Mario m);
        void GotFeather(Mario m);
        void MetMonster(Mario m);
        IState GetState();
    }
}