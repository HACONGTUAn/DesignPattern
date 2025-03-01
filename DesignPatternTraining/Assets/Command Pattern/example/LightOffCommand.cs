
    using UnityEngine;

    namespace Command_Pattern.example
    {
        public class LightOffCommand : ICommand
        {
            private Light _light;

            public LightOffCommand(Light light)
            {
                _light = light;
            }

            public void Execute()
            {
                _light.enabled = false;
            }
        }
    }
