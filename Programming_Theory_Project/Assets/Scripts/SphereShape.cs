using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereShape : Shape // INHERITANCE
{
    private void Awake()
    {
        Name = "SphereShape";
    }

    public override void DisplayText()
    {
        // POLYMORPHISM
        form.text = "Wow: you've clicked sphere shape. Good job!!! ";
    }

    public override void OnClicked()
    {
        //TODO
    }

}
