using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereShape : Shape
{
    private void Awake()
    {
        Name = "SphereShape";
    }

    public override void DisplayText()
    {
        form.text = "'DisplayText' in 'SphereShape' object";
    }

}
