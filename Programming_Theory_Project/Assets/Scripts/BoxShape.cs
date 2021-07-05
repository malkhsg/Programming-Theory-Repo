using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxShape : Shape// INHERITANCE
{ 
    private void Awake()
    {
        Name = "BoxShape_1";
    }

    public override void OnClicked()
    {
        if (Name == "BoxShape_1")
        {
            Name = "BoxShape_2";
        }
        else
        {
            Name = "BoxShape_1";
        }
    }
}
