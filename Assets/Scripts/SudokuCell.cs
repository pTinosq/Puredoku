using TMPro;
using UnityEngine;

public class SudokuCell : MonoBehaviour
{
    public int Value;
    public TextMeshPro textDisplay;

    public void SetValue(int val)
    {
        Value = val;
        textDisplay.text = val.ToString();
    }
}
