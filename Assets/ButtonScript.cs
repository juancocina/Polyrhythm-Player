using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour, IInteractable
{
    [Header("References")]
    public GameObject NotePlayer;
    //private NotePlayerScript nScript;
    
    // Start is called before the first frame update
    void Start()
    {
        //nScript = NotePlayer.GetComponent<NotePlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        Debug.Log("test button");
    }
}
