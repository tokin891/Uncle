using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private List<IInteractableObserver> observers = new List<IInteractableObserver>();

    public void AddObserver(IInteractableObserver observer)
    {
        observers.Add(observer);
    }

    public void DeleteObserver(IInteractableObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotificationObserver()
    {
        foreach (var observer in observers)
        {
            observer.OnInteract();
        }
    }
}

