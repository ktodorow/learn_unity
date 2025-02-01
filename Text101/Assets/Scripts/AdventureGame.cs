using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    private State _state;
    private string _emote = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        _state = startingState;
        textComponent.text = _state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    private void ManageStates()
    {
        State[] nextStates = _state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                _state = nextStates[i];
            }
        }
        
        textComponent.text = _state.GetStateStory();
    }
}
