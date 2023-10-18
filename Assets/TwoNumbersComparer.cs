using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField firstNumberField;
    [SerializeField]
    private TMP_InputField secondNumberField;

    [SerializeField]
    private TMP_InputField resultField;

    public void CompareNumbers()
    {
        double first = double.Parse(firstNumberField.text);
        double second = double.Parse(secondNumberField.text);
        if (first > second)
        {
            resultField.text = first.ToString();
        }
        else if (second > first)
        {
            resultField.text = second.ToString();
        }
        else
        {
            resultField.text = "Equal";
        }
    }

}
