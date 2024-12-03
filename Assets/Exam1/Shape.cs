using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName; 
    public string ShapeName
    {
        get { return shapeName; }
        set { shapeName = value; }

    }

    public void Init(string)
    {

    }

    public abstract float CalculateArea()
    {
        Debug.Log("Square area = "+ value);
    }

    public virtual void Resize()
    {
        Debug.Log(shapeName + "is resized");
    }

    public void Draw()
    {
        Debug.Log("Drawing a" + shapeName);
    }
}
