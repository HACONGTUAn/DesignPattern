using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command_Pattern.example
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.enabled = true;
        }
    }
}