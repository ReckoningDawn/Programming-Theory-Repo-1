using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shape // inheritance
{
    public override void DisplayText() // polymorphism
    {
        ansText.text = "You have selected Green Sphere.";
    }

}
