using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public ControllerCommand controllerCommand;
    public float speed;
    void Start()
    {
        controllerCommand.SetMoveLeftCommand(new MoveLeftCommand(this.transform,speed));
        controllerCommand.SetMoveRightCommand(new MoveRightCommand(this.transform,speed));
        controllerCommand.SetJumpCommand(new MoveUpCommand(this.transform,speed));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            controllerCommand.MoveLeft();
        }

        if (Input.GetKey(KeyCode.V))
        {
            controllerCommand.MoveRight();
        }

        if (Input.GetKey(KeyCode.C))
        {
            controllerCommand.Jump();
        }
    }
}
