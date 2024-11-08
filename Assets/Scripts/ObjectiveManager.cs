using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public static ObjectiveManager instance;
    public bool isObjectiveCollected = false; 

    private void Awake()
    {
        instance = this;
    }

    
    public void CollectObjective()
    {
        isObjectiveCollected = true;
    }
}
