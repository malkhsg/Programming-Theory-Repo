using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxShape : Shape
{ 
    private void Awake()
    {
        Name = "BoxShape";
    }

    public override void DisplayText()
    {
        form.text = "'DisplayText' in 'BoxShape' object";
    }

}
