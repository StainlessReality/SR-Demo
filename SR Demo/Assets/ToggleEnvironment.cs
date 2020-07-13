using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleEnvironment : MonoBehaviour
{

    // Grab the environment to show / hide
    public GameObject toggledObject;

    // Grab the TMP compnent to change text on
    public TextMeshProUGUI textToChange;

    // Initialise a bool to hold state of toggle
    private bool isVisible;
    
    // Start is called before the first frame update
    void Start()
    {
        isVisible = false;
        toggledObject.SetActive(isVisible);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleObject()
    {
        // Toggle state of bool
        isVisible = !isVisible;

        // Enable / disable environment depending on state of bool
        toggledObject.SetActive(isVisible);

        // Change text of TMP component
        if (isVisible)
        {
            // Set text to "push to hide env"
            textToChange.SetText("TAP TO HIDE ENVIRONMENT");
        }
        else
        {
            // Set text to "push to show env"
            textToChange.SetText("TAP TO SHOW ENVIRONMENT");
        }

    }
}
