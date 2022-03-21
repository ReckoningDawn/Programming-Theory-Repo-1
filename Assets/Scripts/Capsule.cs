using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsule : Shape // inheritance
{
    public override void DisplayText() // polymorphism
    {
        ansText.text = "You have selected Blue Capsule.";
    }

}
