using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    private Vector3 basePosition;

    private void Start()
    {
        SetName("Sphere");
        basePosition = transform.position;
    }

    // POLYMORPHISM
    protected override void Motion()
    {
        float y = Mathf.Sin(Time.time);
        transform.position = new Vector3(basePosition.x, y, basePosition.z);
    }
}
