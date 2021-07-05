using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickProcessor : MonoBehaviour
{
    private void OnMouseDown()
    {
        var shape = GetComponent<Shape>();
        if (shape != null)
        {
            shape.DisplayText();
        }
    }
}
