using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpCommand : ICommand
{
    Transform _transformPlayer;
    float _speed = 20f;
    public MoveUpCommand(Transform transformPlayer,float speed)
    {
        _transformPlayer = transformPlayer;
        _speed = speed;
    }
    public void Execute()
    {
       // move Up player
       _transformPlayer.position += Vector3.up * _speed * Time.deltaTime;
    }
}
