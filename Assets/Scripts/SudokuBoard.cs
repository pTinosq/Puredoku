using System;
using UnityEngine;
using UnityEngine.Mathetmatics.Quaternion;

public class SudokuBoard : StereoBehaviour
{
    public GameObject Cell;
    public float cellSize = 1f;
    public float gap = 0.1f;
    public SudokuCell[] board = new SudokuCell[9*9];

    void Start()
    {
        for (int i = 0; i < board.Length; i++)
        {
            int x = i % 9;
            int y = i / 9;
            float spacing = cellSize + gap;
            Vector3 cellCoordinates = new Vector3(x * spacing, -y * spacing, 0); // -y to go down

            GameObject obj = Instantiate(Cell, cellCoordinates, Quaternion.identity);
            SudokuCell sudokuCell = obj.GetComponent<SudokuCell>();
            sudokuCell.SetValue(i % 9); 

            board[i] = sudokuCell;


        }
    }
    void Update() {

    }
}
