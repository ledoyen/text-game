using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    [SerializeField] GameObject linkPrefab;

    private State currentState;
    private GameObject mainScreen;

    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        mainScreen = GameObject.Find("MainScreen");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            menuPanel.SetActive(!menuPanel.activeSelf);
        }
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = currentState.GetNextStates();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                switchToNewState(nextStates[i]);
            }
        }
    }

    private void switchToNewState(State.NextState nextState)
    {
        textComponent.text = currentState.GetStateStory();
        GameObject[] links = GameObject.FindGameObjectsWithTag("Link");
        foreach (var link in links)
        {
            Destroy(link);
        }
        
    }
}
