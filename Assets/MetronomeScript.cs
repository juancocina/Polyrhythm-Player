using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetronomeScript : MonoBehaviour, IInteractable
{
    [Header("References")]
    public GameObject Metronome;
    private StartStopScript metronomeScript;
    // Start is called before the first frame update
    void Start()
    {
        metronomeScript = Metronome.GetComponent<StartStopScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact() 
    {
        metronomeScript.startStop();
    }
}
