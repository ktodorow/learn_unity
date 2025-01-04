using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string debugString = "Hi. This is debug log.";
        Debug.Log($"{debugString}");

        int min = 1;
        int max = 1000;
        
        Debug.Log($"This is the lowest number you can pick: {min}");
        Debug.Log($"This is the highest number you can pick: {max}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("you pressed up arrow");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("you pressed down arrow");
        }
        if (Input.GetKeyDown(KeyCode.Return) ||
            Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("you pressed enter key");
        }
    }
}
