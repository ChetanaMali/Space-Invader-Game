using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour, IDebugStatement
{
    public void DebugStatement()
    {
        Debug.Log("Collide with Square!!");
    }

}
