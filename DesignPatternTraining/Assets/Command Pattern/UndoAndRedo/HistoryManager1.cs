using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undoAndRedo
{
    public class HistoryManager : MonoBehaviour
    {
        private Stack<ICommand> history = new Stack<ICommand>();
        private Stack<ICommand> repdoHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            history.Push(command);
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                ICommand command = history.Pop();
                command.Undo();
                repdoHistory.Push(command);
            }
        }

        public void Redo()
        {
            if (repdoHistory.Count > 0)
            {
                ICommand command = repdoHistory.Pop();
                command.Undo();
            }
        }
    }
}