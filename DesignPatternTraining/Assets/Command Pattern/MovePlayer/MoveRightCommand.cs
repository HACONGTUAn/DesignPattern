using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MovePlayerCommandPattern
{
    public class MoveRightCommand : ICommand
    {
        Transform _transformPlayer;
        private Vector3 _previousPosition;
        float _speed = 20f;

        public MoveRightCommand(Transform transformPlayer, float speed)
        {
            _transformPlayer = transformPlayer;
            _speed = speed;
        }

        public void Execute()
        {
            _previousPosition = _transformPlayer.position;
            _transformPlayer.position += Vector3.right * _speed * Time.deltaTime;
        }

        public void Undo()
        {
            _transformPlayer.position = _previousPosition;
        }
    }
}