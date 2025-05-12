using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private bool isRotate;
    public Vector3 angle;

    private void Awake()
    {
        isRotate = false;
    }

    private void Update()
    {
        SetRotate(isRotate);
    }

    public void Rotate()
    {
        transform.Rotate(angle*Time.deltaTime);
    }

    public void ToggleRotate()
    {
        isRotate = !isRotate;
    }

    public void SetRotate(bool value)
    {
        if (value)
        {
            Rotate();
        }
    }
}
