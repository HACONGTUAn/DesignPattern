using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undoAndRedo
{
    public class MoveUpCommand : ICommand
    {
        Transform _transformPlayer;
        private Vector3 _previousPosition;
        float _speed = 20f;

        public MoveUpCommand(Transform transformPlayer, float speed)
        {
            _transformPlayer = transformPlayer;
            _speed = speed;
        }

        public void Execute()
        {
            // move Up player
            _previousPosition = _transformPlayer.position;
            _transformPlayer.position += Vector3.up * _speed * Time.deltaTime;
        }

        public void Undo()
        {
            _transformPlayer.position = _previousPosition;
        }
    }
}