using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePlayer : MonoBehaviour, IInteractable 
{
    [Header("References")]
    public AudioSource source;
    public AudioClip clip;
    public GameObject metronome;
    public int rhythm;
    public bool OnOff;

    private StartStopScript st;
    private double dTime;
    private double globalBpm;
    private double nextTick = 0.0F;

    public void Interact() {
        // if(OnOff == false) OnOff = true;
        // else if(OnOff == true) OnOff = false;
    }

    void Start() {
        OnOff = false;
        st = metronome.GetComponent<StartStopScript>();
        globalBpm = st.bpm;
        //setRhyhtm();
        //Debug.Log("Rhythm: " + rhythm + " dTime: " + dTime);
        nextTick = AudioSettings.dspTime + dTime;
    }

    void Update() {
        setRhyhtm();
        if(st.running == true && OnOff == true)
        {
            //Debug.Log(AudioSettings.dspTime + " " + nextTick);
            if(AudioSettings.dspTime >= nextTick){
                source.PlayScheduled(AudioSettings.dspTime);
                nextTick += dTime;
            }

        } else 
        {
            nextTick = AudioSettings.dspTime + dTime;
        }
        return;
    }

    public void setRhyhtm(){
        globalBpm = st.bpm;
        rhythm = rhythm;
        switch(rhythm)
        {
            /*
                Ex of 120 global BPM
                Interactable 1 Stats: 2000ms per hit     in the duration of 4 bars 
                Interactable 2 Stats: 1750ms per hit
                Interactable 3 Stats: 1500ms per hit
                Interactable 4 Stats: 1250ms 
                Interactable 5 Stats: 1000ms 
                Interactable 6 Stats: 750 ms 
                Interactable 7 Stats: 500 ms 
                Interactable 8 Stats: 250 ms 

            */
            case 1:
                // (16/16)
                dTime = (60 / globalBpm) * 4;
                break;
            case 2:
                // (15 / 16)
                dTime = ((60 / globalBpm) / 4) * 15;
                break;
            case 3:
                // (14 / 16)
                dTime = ((60 / globalBpm) / 2) * 7;
                break;
            case 4:
                // (13/ 16)
                dTime = ((60 / globalBpm) / 4) * 13;
                break;
            case 5:
                // (12 / 16)
                dTime = (60 / globalBpm) * 3;
                break;
            case 6:
                // (11/ 16)
                dTime = ((60 / globalBpm) / 4) * 11;
                break;
            case 7:
                // (10 / 16)
                dTime = ((60 / globalBpm) / 2) * 5;
                break;
            case 8:
                // (9 / 16)
                dTime = ((60 / globalBpm) / 4) * 9;
                break;
            case 9:
                // (8/16)
                dTime = (60 / globalBpm) * 2 ;
                break;
            case 10:
                // (7/16)
                dTime = ((60 / globalBpm) / 4) * 7;
                break;
            case 11:
                // (6/16)
                dTime = ((60 / globalBpm) / 2) * 3;
                break;
            case 12:
                // (5/16)
                dTime = ((60 / globalBpm) / 4) * 5;
                break;
            case 13:
                // (4/16)
                dTime = (60 / globalBpm);
                break; 
            case 14:
                // (3/16)
                dTime = ((60 / globalBpm) / 4) * 3;
                break;
            case 15:
                // (2/16)
                dTime = (60 / globalBpm) / 2;
                break;
            case 16:
                // (1/16)
                dTime = (60 / globalBpm) / 4;
                break;
        }
        /*
            To break down the musical notation
            even though case 1 is (16/16) and case 16 is (1/16)
            A 16th note in music is the smaller note
            As is a 1/4 note, in this case it would be 4/16
        */
    }
}
