using UnityEngine;

namespace Command_Pattern.example
{
    public class LightControl: MonoBehaviour
    {
        public Light light;
        private LightSwitch lightSwitch;

        void Start()
        {
            ICommand onCommand = new LightOnCommand(light);
            ICommand offCommand = new LightOffCommand(light);
            lightSwitch = new LightSwitch(onCommand, offCommand);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                lightSwitch.TurnOn();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                lightSwitch.TurnOff();
            }
        }
    }
}