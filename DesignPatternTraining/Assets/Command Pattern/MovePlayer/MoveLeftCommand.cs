using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    Transform _transformPlayer;
    float speed = 20f;

    public MoveLeftCommand(Transform transformPlayer)
    {
        _transformPlayer = transformPlayer;
    }
    public void Execute()
    {
        _transformPlayer.position += _transformPlayer.position * speed * Time.deltaTime;
    }
}
