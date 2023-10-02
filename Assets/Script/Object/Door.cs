using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractableObserver
{
    private InteractableObject interctableOjbect;

    private void Start()
    {
        interctableOjbect = GetComponent<InteractableObject>();
        interctableOjbect.AddObserver(this);
    }

    public void OnInteract()
    {
        Debug.Log("Open Door");
    }
}
