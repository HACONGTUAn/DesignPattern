namespace Command_Pattern.example
{
    public class LightSwitch
    {
        private ICommand _onCommand;
        private ICommand _offCommand;

        public LightSwitch(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void TurnOn()
        {
            _onCommand.Execute();
        }

        public void TurnOff()
        {
            _offCommand.Execute();
        }
    }
}