using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape // inheritance
{
    // Start is called before the first frame update
    public override void Start()
    {
    }

    public override void DisplayText() // polymorphism
    {
        ansText.text = "You have selected Red Cube.";
    }

}