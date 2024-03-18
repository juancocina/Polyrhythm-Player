using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour, IInteractable
{
    [Header("References")]
    public GameObject nPlayer;
    private NotePlayer nScript;
    //private NotePlayerScript nScript;
    
    // Start is called before the first frame update
    void Start()
    {
        nScript = nPlayer.GetComponent<NotePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if(nScript.OnOff == false) nScript.OnOff = true;
        else if (nScript.OnOff == true) nScript.OnOff = false;
    }
}
