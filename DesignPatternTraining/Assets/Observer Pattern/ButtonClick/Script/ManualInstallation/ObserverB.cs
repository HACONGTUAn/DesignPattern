using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObserverB : MonoBehaviour, IButtonObserver
{
    [SerializeField] ButtonSubject buttonSubject;
    private Text textCall;
    private void Start()
    {
        textCall = GetComponent<Text>();
        buttonSubject.RegisterObserver(this);
    }
    public void OnButtonClicked()
    {
        textCall.text = "Xin chao the gioi";
    }
}
