using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace undo
{
    public class HistoryManager : MonoBehaviour
    {
        private Stack<ICommand> history = new Stack<ICommand>();

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
            }
        }
    }
}