using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RowButtonScript : MonoBehaviour
{
    public GridButtonScript[] childButtons = new GridButtonScript[3];
    public int[] childGridNumbers = new int[3];
    public SolverBehavior solver;
    public SolverBehavior.GridRows gridRowType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighlightAllChildren()
    {
        foreach(GridButtonScript btn in childButtons)
        {
            btn.HighLightIt();
            Debug.Log("test001");
        }
    }

    public void ReleaseHighlights()
    {
        foreach (GridButtonScript btn in childButtons)
        {
            btn.ReleaseHighLight();
            Debug.Log("test002");
        }
    }

    public int[] ReturnCombinedNumber()
    {
        return childGridNumbers;
    }
}