using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Text ansText;
    public string ShapeName { get; private set; } = "Shape"; // Encapsulation

    private void OnMouseDown() // abstraction
    {
        DisplayText();
        DisplayLog();
    }

    public virtual void DisplayText() // polymorphism
    {
        ansText.text = "You have selected color shape.";
    }

    private void DisplayLog()
    {
        Debug.Log($"Selected The {ShapeName}: {gameObject.name}");
    }

}
