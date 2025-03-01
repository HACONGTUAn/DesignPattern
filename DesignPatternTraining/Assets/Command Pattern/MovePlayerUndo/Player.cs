using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undo
{
    public class Player : MonoBehaviour
    {
        // Start is called before the first frame update
        public ControllerCommand controllerCommand;
        public HistoryManager historyManager;

        public float speed;

        void Start()
        {
            // controllerCommand.SetMoveLeftCommand(new MoveLeftCommand(this.transform,speed));
            // controllerCommand.SetMoveRightCommand(new MoveRightCommand(this.transform,speed));
            // controllerCommand.SetJumpCommand(new MoveUpCommand(this.transform,speed));
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.X))
            {
                historyManager.ExecuteCommand(new MoveLeftCommand(this.transform, speed)); // Tạo mới instance Command
            }

            if (Input.GetKey(KeyCode.V))
            {
                historyManager.ExecuteCommand(new MoveRightCommand(this.transform, speed)); // Tạo mới instance Command
            }

            if (Input.GetKey(KeyCode.C))
            {
                historyManager.ExecuteCommand(new MoveUpCommand(this.transform, speed)); // Tạo mới instance Command
            }

            if (Input.GetKey(KeyCode.Z))
            {
                historyManager.Undo();
            }
        }
    }
}