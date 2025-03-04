using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BotMove
{
    public class JumpingStrategy : MonoBehaviour, IMoveStrategy
    {
        public void Move(Transform objectToMove)
        {
            objectToMove.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
