using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable {
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //if E is pressed down
        if(Input.GetKeyDown(KeyCode.E)) {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    Debug.Log("Hit");
                    interactObj.Interact();
                }
            }
        }

        // if left Mouse click
        if(Input.GetMouseButtonDown(0)) {
            Debug.Log("Left Click");
            Ray r = cam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(r.origin, r.direction * 20, Color.green);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange)) {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) {
                    Debug.Log("Hit");
                    interactObj.Interact();
                }
            }
        }
    }
}
