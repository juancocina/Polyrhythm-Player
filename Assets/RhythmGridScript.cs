using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RhythmGridScript : MonoBehaviour, IInteractable
{
    public int rhythmSelect;
    public GameObject nPlayer;
    private NotePlayer nScript;
    // Start is called before the first frame update
    void Start()
    {
        nScript = nPlayer.GetComponent<NotePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Interact() {
        Debug.Log("GridButton Test");
        nScript.rhythm = rhythmSelect;
    }
}
