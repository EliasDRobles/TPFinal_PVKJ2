using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Platform : MonoBehaviour
{
    public abstract void PerformAction();

    private void Update()
    {
        PerformAction();
    }
}
