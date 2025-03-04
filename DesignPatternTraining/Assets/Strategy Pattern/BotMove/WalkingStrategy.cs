using UnityEngine;

namespace BotMove
{
    public class WalkingStrategy : MonoBehaviour, IMoveStrategy
    {
        public void Move(Transform objectToMove)
        {
            objectToMove.Translate(Vector3.left * Time.deltaTime);
        }
    }
}