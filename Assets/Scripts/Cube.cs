using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : Shape // inheritance
{
    public override void DisplayText() // polymorphism
    {
        ansText.text = "You have selected Red Cube.";
    }

}
