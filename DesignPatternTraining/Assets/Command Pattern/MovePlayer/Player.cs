using System.Collections;
using System.Collections.Generic;
using undoAndRedo;
using UnityEngine;

namespace MovePlayerCommandPattern
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
                historyManager.ExecuteCommand(new undoAndRedo.MoveLeftCommand(this.transform,speed));
            }

            if (Input.GetKey(KeyCode.V))
            {
                historyManager.ExecuteCommand(new undoAndRedo.MoveRightCommand(this.transform,speed));
            }

            if (Input.GetKey(KeyCode.C))
            {
                historyManager.ExecuteCommand(new undoAndRedo.MoveUpCommand(this.transform,speed));
            }

            if (Input.GetKey(KeyCode.B))
            {
                historyManager.Undo();
            }
           
        }
    }
}