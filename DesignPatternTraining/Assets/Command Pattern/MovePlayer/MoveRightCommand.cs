using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{ 
    Transform _transformPlayer;
    float speed = 20f;
    
    public MoveRightCommand(Transform transformPlayer)
    {
        _transformPlayer = transformPlayer;
    }
    public void Execute()
    {
        _transformPlayer.position += Vector3.right * speed * Time.deltaTime;
    }
}
