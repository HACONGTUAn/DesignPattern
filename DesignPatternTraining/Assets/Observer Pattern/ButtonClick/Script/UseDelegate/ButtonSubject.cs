using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UseDelegate
{

    public class ButtonSubject : MonoBehaviour
    {
        public event Action OnButtonClicked;

        public void ButtonClicked()
        {
            OnButtonClicked?.Invoke();
        }
        private void Start()
        {
            Button button = GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(ButtonClicked);
            }
        }
    }
}
