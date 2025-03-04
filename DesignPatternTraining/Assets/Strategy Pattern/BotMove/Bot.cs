using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BotMove
{
    public class Bot : MonoBehaviour
    {
        private IMoveStrategy moveStrategy;
        public JumpingStrategy jumpingStrategy;
        public WalkingStrategy walkingStrategy;
        public FlyingStrategy flyingStrategy;   

        void Start()
        {
            if (moveStrategy == null)
            {
                moveStrategy = new WalkingStrategy();
            }
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                moveStrategy = new JumpingStrategy();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                moveStrategy = new WalkingStrategy();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                moveStrategy = new FlyingStrategy();
            }
            if (moveStrategy != null)
            {
                moveStrategy.Move(this.transform); 
            }
        }

       
    }
}
