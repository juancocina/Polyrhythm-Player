using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BPMAdjustments : MonoBehaviour, IInteractable
{
    private Button self;
    [Header("References")]
    public GameObject Metronome;
    private StartStopScript metronomeScript;
    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Button>();
        metronomeScript = Metronome.GetComponent<StartStopScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact() {
        if(self.name == "BPMadd") metronomeScript.addBPM();
        if(self.name == "BPMsub") metronomeScript.subtractBPM();
    }
}
