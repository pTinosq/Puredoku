using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class SudokuCell : MonoBehaviour
{
    public int Value;
    private TextMeshPro textDisplay;

    void Awake()
    {
        textDisplay = GetComponentInChildren<TextMeshPro>();
    }

    public void SetValue(int val)
    {
        Value = val;
        textDisplay..text = val.ToString();
    }
}
