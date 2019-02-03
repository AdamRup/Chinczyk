using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    interface IPawn
    {
        void Move(int NewPosition, GameBoard gameBoard);
    }
}
