using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    
    [SerializeField]
    private TMP_InputField firstNumberField;
    [SerializeField]
    private TMP_InputField secondNumberField;

    [SerializeField]
    private TMP_InputField resultField;
    public void SumNumbers()
    {
        resultField.text = (double.Parse(firstNumberField.text) + double.Parse(secondNumberField.text)).ToString();
    }
    public void MinusNumbers()
    {
        resultField.text = (double.Parse(firstNumberField.text) - double.Parse(secondNumberField.text)).ToString();
    }
    public void MultiplyNumbers()
    {
        resultField.text = (double.Parse(firstNumberField.text) * double.Parse(secondNumberField.text)).ToString();
    }
    public void DivideNumbers()
    {
        resultField.text = (double.Parse(firstNumberField.text) / double.Parse(secondNumberField.text)).ToString();
    }
}
