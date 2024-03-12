using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // added to be able to access slider

public class SliderScript : MonoBehaviour, IInteractable
{
    public Slider volumeSlider;
    private float yCoord;
    private static float yChange = 0.50f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void passHitInfo(float y) {
        yCoord = y;
    }
    public void Interact() 
    {
        Debug.Log("Slider Collider Triggered");
        Debug.Log("Y Coordinate Hit: " + yCoord);
        Debug.Log("Slider Value: " + volumeSlider.value);

        volumeSlider.value = yCoord - 1.00f;
        Debug.Log("Slider Value after Change: " + volumeSlider.value);
    }
}
