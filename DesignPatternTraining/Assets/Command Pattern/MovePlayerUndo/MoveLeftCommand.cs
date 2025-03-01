using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undo
{
    public class MoveLeftCommand : ICommand
    {
        Transform _transformPlayer;
        private Vector3 _previousPosition;
        float _speed = 2f;

        public MoveLeftCommand(Transform transformPlayer, float speed)
        {
            _transformPlayer = transformPlayer;
            _speed = speed;
        }

        public void Execute()
        {
            _previousPosition = _transformPlayer.position;
            _transformPlayer.position += Vector3.left * _speed * Time.deltaTime;
        }

        public void Undo()
        {
            _transformPlayer.position = _previousPosition;
        }
    }
}