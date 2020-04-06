using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RowButtonScript : MonoBehaviour
{
    GridButtonScript[] childButtons = new GridButtonScript[3];
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
        }
    }

    public void ReleaseHighlights()
    {
        foreach (GridButtonScript btn in childButtons)
        {
            btn.ReleaseHighLight();
        }
    }
}