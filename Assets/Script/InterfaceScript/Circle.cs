using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour, IDebugStatement
{
    public void DebugStatement()
    {
        Debug.Log("Collide with circle!");
    }

    
}
