using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulteShape : Shape
{
    private void Awake()
    {
       Name = "CapsuleShape";
    }

    public override void DisplayText()
    {
        form.text = "'DisplayText' in 'CapsulteShape' object";
    }
}
