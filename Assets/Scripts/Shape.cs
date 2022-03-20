using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Text ansText;

    // Start is called before the first frame update
    public virtual void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        DisplayText();
    }

    public virtual void DisplayText()
    {
        ansText.text = "You have selected color shape.";
    }

}
