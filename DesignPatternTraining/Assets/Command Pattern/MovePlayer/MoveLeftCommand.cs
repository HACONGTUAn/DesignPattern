using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    Transform _transformPlayer;
    float _speed = 2f;

    public MoveLeftCommand(Transform transformPlayer,float speed)
    {
        _transformPlayer = transformPlayer;
        _speed = speed;
    }
    public void Execute()
    {
        _transformPlayer.position += Vector3.left * _speed * Time.deltaTime;
    }
}
