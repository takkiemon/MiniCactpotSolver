using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GridButtonScript : MonoBehaviour
{
    public Image buttonImage;
    public Color defaultColor;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = buttonImage.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighLightIt()
    {
        buttonImage.color = new Color(178, 178, 178);
    }

    public void ReleaseHighLight()
    {
        buttonImage.color = defaultColor;
    }
}