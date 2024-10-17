using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Mario
{
    public class Mario
    {
        private IState _state;
        public IState State 
        { 
            get => _state; 
            set 
            {
                _state = value;
            }
        }
        private int _lifeCount;
        private int _coinCount;
        private bool _gameOver = false;
        private int _bonusLifeCost = 1000;
        public int CoinCount    
        { 
            get => _coinCount; 
            set
            {
                _coinCount += value;
                if(_coinCount >= _bonusLifeCost)
                {
                    _coinCount = _coinCount - _bonusLifeCost;
                    BonusLeben();
                }
            }
        }

        private SmallMario _smallMario;
        private FireMario _fireMario;
        private CapeMario _capeMario;
        private SuperMario _superMario;

        public void BonusLeben()
        {
            _lifeCount++;
            Console.WriteLine($"Mario hat {_bonusLifeCost} Münzen gesammelt und ein Bonusleben erhalten.");
            Console.WriteLine($"Neue Lebenanzahl:{_lifeCount}");
            Console.WriteLine($"Neue Münzanzahl:{CoinCount}");
            Console.WriteLine();
        }
        public Mario()
        {
            
            _lifeCount = 5;
            _coinCount = 0;
             _smallMario = new SmallMario();
             _fireMario = new FireMario();
             _capeMario = new CapeMario();
             _superMario = new SuperMario();
            //_state = _smallMario;
            _state = new SmallMario();

        }
        public override string ToString()
        {
            if(_gameOver == false)
            {
                return $"Mario ist aktuell {_state.GetType().Name}, hat {CoinCount} Münzen und {_lifeCount} Leben";
            }
            else
            {
                return "Spielstatus: Game Over";
            }
            
        }
        public IState GetState()
        {
            return _state;
        }
        public void CoinsAdd(int menge)
        {
            if(!_gameOver)
            {
                Console.WriteLine($"Coins+{menge} Gesamtcoins:{_coinCount + menge}");
                CoinCount = menge;
            }

            
        }
        public void lifeLost()
        {
            
                _lifeCount--;
                if (_lifeCount == 0)
                {
                    _gameOver = true;
                    Console.WriteLine("Gamer Over!");
                }
                else
                {
                Console.WriteLine($"Übrige Leben:{_lifeCount}\n");
                }
        }

        public bool ReturnGameOver()
        {
            return _gameOver;
        }


        public void GotFeather()
        {
            _state.GotFeather(this);
        }

        public void GotFireflower()
        {
            _state.GotFireflower(this);
        }
 

        public void GotMushroom()
        {
            _state.GotMushroom(this);
        }

        public void MetMonster()
        {
            _state.MetMonster(this);
        }

        public void SetState(IState status)
        {
                State = status;
        }


    }
}