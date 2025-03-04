using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BotMove
{
    public interface IMoveStrategy
    {
        void Move(Transform objectToMove);
    }
}


