using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class StartStopScript : MonoBehaviour, IInteractable
{
    // Metronome Section
    [Header("References")]
    [Range(60.0F,200.0F)]
    public double bpm = 140.0F;
    public int signatureHi = 4;
    public int signatureLo = 4;
    public bool running;
    

     private double nextTick = 0.0F;
    // private double sampleRate = 0.0F;
    private int accent;
    
    private double bpmInSeconds;

    void Start() 
    {
        accent = signatureHi;
        bpmInSeconds = 60 / bpm;
        //Debug.Log("dspTime" + AudioSettings.dspTime);
        running = false;
    }

    public void Interact() 
    {
        Debug.Log("Test Start/Stop");
        if(running == false) {
            Debug.Log(bpmInSeconds);
            bpm = bpm;
            bpmInSeconds = 60 / bpm;
            nextTick = AudioSettings.dspTime + bpmInSeconds;
            accent = 1;
            running = true;
        }
        else if(running == true) {
            running = false;
        }
    }

    void Update()
    {
        if(!running) return;
        else 
        {
            //Debug.Log(AudioSettings.dspTime + " " + nextTick);
            if(AudioSettings.dspTime >= nextTick)
            {
                if(accent >= signatureHi){
                    Debug.Log("Tock" + accent + "/" + signatureHi);
                    accent = 1;
                }else {
                    Debug.Log("Tick" + accent + "/" + signatureHi);
                    accent++;
                }
                nextTick += bpmInSeconds;
            }
        }
    }
}
