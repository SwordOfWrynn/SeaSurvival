using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WorldManager : MonoBehaviour
{

    public static WorldManager Instance { get; protected set; }

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null)
        {
            UnityEngine.Debug.Log("There is more than 1 WorldManager in the Scene!");
            return;
        }
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
