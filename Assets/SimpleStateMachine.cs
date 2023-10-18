using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStateMachine : MonoBehaviour
{
    [SerializeField]
    private GameObject calculationScreen;
    [SerializeField]
    private GameObject compareScreen;

    private GameObject currentScreen;

    private void Start()
    {
        calculationScreen.SetActive(true);
        currentScreen = calculationScreen;
    }

    public void ChangeState(GameObject state)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false); 
            state.SetActive(true);
            currentScreen = state;
        }
    }
}
