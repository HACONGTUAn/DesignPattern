
    using UnityEngine;

    public class ControllerCommand : MonoBehaviour
    {
        private ICommand _moveLeftCommand;
        private ICommand _moveRightCommand;
        private ICommand _jumpCommand;
        
        public void SetMoveLeftCommand(ICommand command)
        {
            _moveLeftCommand = command;
        }

        public void SetMoveRightCommand(ICommand command)
        {
            _moveRightCommand = command;
        }

        public void SetJumpCommand(ICommand command)
        {
            _jumpCommand = command;
        }
        public void MoveLeft()
        {
            _moveLeftCommand?.Execute();
        }

        public void MoveRight()
        {
            _moveRightCommand?.Execute();
        }

        public void Jump()
        {
            _jumpCommand?.Execute();
        }
    }
