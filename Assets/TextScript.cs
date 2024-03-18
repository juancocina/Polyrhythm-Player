using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    [Header("References")]
    public GameObject Metronome;
    private StartStopScript metronomeScript;

    public TMP_Text bpmText;
    // Start is called before the first frame update
    void Start()
    {
        metronomeScript = Metronome.GetComponent<StartStopScript>();
        bpmText.text = metronomeScript.bpm + "";
    }

    // Update is called once per frame
    void Update()
    {
        bpmText.text = metronomeScript.bpm + "";
    }
}
