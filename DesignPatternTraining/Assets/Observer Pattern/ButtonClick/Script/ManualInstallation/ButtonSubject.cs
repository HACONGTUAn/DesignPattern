using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSubject : MonoBehaviour
{
    
    private List<IButtonObserver> observers = new List<IButtonObserver>();

    public void RegisterObserver(IButtonObserver observer)
    {
        observers.Add(observer);
    }
    public void UnregisterObserver(IButtonObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (IButtonObserver observer in observers)
        {
            observer.OnButtonClicked(); 
        }
    }

    public void ButtonClicked()
    {
        NotifyObservers();
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
