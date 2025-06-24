using System;
using UnityEngine;

public class SudokuBoard : MonoBehaviour
{
    public GameObject Cell;
    public SudokuCell[] board = new SudokuCell[9 * 9];

    void Start()
    {
        float screenPixelWidth = Screen.width;
        float screenWidthWorldUnits = 2f * Camera.main.orthographicSize * Camera.main.aspect;
        float worldUnitsPerPixel = screenWidthWorldUnits / screenPixelWidth;

        float gap = 0f * worldUnitsPerPixel;      // gap between cells = 4px
        float padding = 12f * worldUnitsPerPixel; // board padding = 6px per side

        float usableWidth = screenWidthWorldUnits - (padding * 2f);
        float totalGap = gap * 8f;
        float targetCellSize = (usableWidth - totalGap) / 9f;
        float spacing = targetCellSize + gap;


        for (int i = 0; i < board.Length; i++)
        {
            int x = i % 9;
            int y = i / 9;

            Vector3 cellCoordinates = new(x * spacing, -y * spacing, 0);

            GameObject obj = Instantiate(Cell, cellCoordinates, Quaternion.identity, transform);
            obj.transform.localScale = Vector3.one * targetCellSize;

            SudokuCell sudokuCell = obj.GetComponent<SudokuCell>();
            sudokuCell.SetValue((i % 9) + 1);

            board[i] = sudokuCell;
        }

        // Center the board
        float boardWidth = 9f * spacing;
        float boardHeight = 9f * spacing;
        transform.position = new Vector3(-boardWidth / 2f + spacing / 2f, boardHeight / 2f - spacing / 2f, 0);
    }

    void Update() { }
}
