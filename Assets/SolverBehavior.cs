﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

public class SolverBehavior : MonoBehaviour
{
    //int[,] grid = new int[3,3];
    public int attemptsLeft = 3;
    public int[,] trueGrid = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
    public bool[,] visibleGrid = { { false, false, false }, { false, false, false }, { false, false, false } };
    int[] numberSet = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public int rnd1, rnd2;
    public Button[] gridButtons = new Button[9];
    public Button[] rowButtons = new Button[8];

    public StringBuilder gridString;

    float[] payout =
    {
        10000, 36, 720, 360, 80, // 6-10
        252, 108, 72, 54, 180, // 11-15
        72, 180, 119, 36, 306, // 16-20
        1080, 144, 1800, 3600 // 20-24
    };

    public enum gridRows
    {
        VerticalRow1,
        VerticalRow2,
        VerticalRow3,
        HorizontalRow1,
        HorizontalRow2,
        HorizontalRow3,
        DiagonalRowLeft, 
        DiagonalRowRight
    }

    // Start is called before the first frame update
    void Start()
    {
        RestartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        attemptsLeft = 3;
        trueGrid = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        visibleGrid = new bool[,] { { false, false, false }, { false, false, false }, { false, false, false } };
        gridString = new StringBuilder("");
        FillGrid();
        PrintGrid(true);
        UpdateGrid();
    }

    float CalculateAverages(int first, int second, int third) // wip
    {
        return payout[first + second + third];
    }

    public void FillGrid()
    {
        for (int i = 0; i < 9; i++)
        {
            int failCounter = 0;
            do
            {
                rnd1 = Random.Range(0, 3);
                rnd2 = Random.Range(0, 3);
                failCounter++;
                if (failCounter >= 500)
                {
                    Debug.Log("infinite loop maybe");
                    break;
                }
            }
            while (trueGrid[rnd1, rnd2] != 0);
            trueGrid[rnd1, rnd2] = numberSet[i];
        }
    }

    public void PrintGrid(bool showAll)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                gridString.Append("[");
                if (showAll || visibleGrid[i,j])
                {
                    gridString.Append(trueGrid[i, j]);
                }
                else
                {
                    gridString.Append("X");
                }
                gridString.Append("]");
            }
            gridString.Append("\n");
        }
        Debug.Log(gridString.ToString());
    }

    public void UpdateGrid()
    {
        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (visibleGrid[i, j])
                {
                    gridButtons[j * 3 + i].GetComponentInChildren<Text>().text = trueGrid[i, j].ToString();
                }
                else
                {
                    gridButtons[j * 3 + i].GetComponentInChildren<Text>().text = "";
                }
            }
        }
    }

    public float GetPayout(int sumOfRow)
    {
        return payout[sumOfRow - 6];
    }

    public float GetPayout(int first, int second, int third)
    {
        return payout[first + second + third - 6];
    }
}
