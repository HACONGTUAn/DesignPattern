using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undoAndRedo
{
    public class Player : MonoBehaviour
    {
        // Start is called before the first frame update
     
        public HistoryManager historyManager;

        public float speed;

      

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
            if (Input.GetKey(KeyCode.B))
            {
                historyManager.Redo();
            }
        }
    }
}