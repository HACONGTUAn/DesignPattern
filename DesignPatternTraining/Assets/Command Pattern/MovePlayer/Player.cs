using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public ControllerCommand controllerCommand;
    void Start()
    {
        controllerCommand.SetMoveLeftCommand(new MoveLeftCommand(this.transform));
        controllerCommand.SetMoveRightCommand(new MoveRightCommand(this.transform));
        controllerCommand.SetJumpCommand(new MoveUpCommand(this.transform));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            controllerCommand?.MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            controllerCommand?.MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            controllerCommand?.Jump();
        }
    }
}
