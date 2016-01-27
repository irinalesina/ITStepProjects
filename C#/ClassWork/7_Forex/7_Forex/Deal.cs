using System;
using System.Collections.Generic;



namespace _7_Forex
{
    class Deal : EventArgs
    {
        Player player;
        int money;
        public bool is_fair;

        public Deal(Player gamer, int cash, bool fair)
        {
            player = gamer;
            money = cash;
            is_fair = fair;
        }

        
        
    }
}
