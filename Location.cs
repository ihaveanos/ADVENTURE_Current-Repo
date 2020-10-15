/* Copright (C) 2020 Kenan Marriott-Baillie */
using System;

namespace ADVENTURE
{
    class Location
    {
        //Properties
        public string _description;
        private bool _canGoUp;  // 0
        private bool _canGoDown; // 1
        private bool _canGoLeft; // 2
        private bool _canGoRight; // 3
        //Constructor
        public Location( string desc )
        {
            _canGoUp = true;
            _canGoDown = true;
            _canGoLeft = true;
            _canGoRight = true;
            _description = desc;
        }





        public bool CanGo( int direction )
        {
            switch (direction)
            {
                case 0:
                {
                    return _canGoUp;
                }
                 case 1:
                {
                    return _canGoDown;
                }
                 case 2:
                {
                    return _canGoLeft;
                }
                 case 3:
                {
                    return _canGoRight;
                }
                default:{
                    return false;
                }
            }
        }  
    }


}