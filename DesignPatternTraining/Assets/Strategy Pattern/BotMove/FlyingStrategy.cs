using UnityEngine;
namespace BotMove
{
    public class FlyingStrategy : MonoBehaviour, IMoveStrategy
    {
        private float speed = 2f;
        private float rotationSpeed = 100f;

        public void Move(Transform objectToMove)
        {
            objectToMove.Translate(Vector3.forward * speed * Time.deltaTime);
            objectToMove.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}