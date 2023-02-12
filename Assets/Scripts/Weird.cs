using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Weird : Shape
{
    private void Start()
    {
        SetName("Weird");
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        infoText.text = "Definately not a regular type of shape.";
    }
}
