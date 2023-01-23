using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public List<GameObject> GameObjectList = new List<GameObject>();

    private void Start()
    {
        foreach (GameObject x in GameObjectList)
        {
            Destroy(x);
        }
    }
}
