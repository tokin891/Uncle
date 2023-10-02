using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] Camera cameraMain;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.E))
            return;

        RaycastHit hit;
        if (!Physics.Raycast(cameraMain.transform.position, cameraMain.transform.forward, out hit))
            return;
        
        if (!hit.transform.TryGetComponent(out InteractableObject IObject))
            return;
        
        IObject.NotificationObserver();
    }
}
