using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UseDelegate
{
    public class ConsoleObserverA : MonoBehaviour
    {
        public ButtonSubject _subject;

        private void OnEnable()
        {
            if (_subject != null)
            {
                _subject.OnButtonClicked += ButtonClickedHandler;
            }
        }

        private void OnDisable()
        {
            if (_subject != null)
            {
                _subject.OnButtonClicked -= ButtonClickedHandler;
            }
        }

        private void ButtonClickedHandler()
        {
            GetComponent<Text>().text = "xin chao the gioi";
        }
    }

}