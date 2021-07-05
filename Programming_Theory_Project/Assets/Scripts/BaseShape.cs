using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected Text form;
    protected string _name;

    public virtual void DisplayText()
    {
        form.text = "'DisplayText' in " + Name + " object";
    }

    public abstract void OnClicked(); // ABSTRACTION

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
