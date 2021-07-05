using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected Text form;
    protected string _name;

    public virtual void DisplayText()
    {
        // ABSTRACTION
        form.text = "'DisplayText' in " + Name + " object";
    }

    public string Name
    {
        // ENCAPSULATION
        get
        {
            return _name;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
        }
    }
}
