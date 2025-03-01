using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{ 
    Transform _transformPlayer;
    float _speed = 20f;
    
    public MoveRightCommand(Transform transformPlayer,float speed)
    {
        _transformPlayer = transformPlayer;
        _speed = speed;
    }
    public void Execute()
    {
        _transformPlayer.position += Vector3.right * _speed * Time.deltaTime;
    }
}
