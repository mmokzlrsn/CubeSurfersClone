using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    bool isCollected;
    float index;

    private void Start()
    {
        isCollected = false;
    }

    private void Update()
    {
        if(isCollected)
        transform.localPosition = new Vector3(0, index, 0);
    }

    public bool GetIsCollected()
    {
        return isCollected;
    }

    public void Collected()
    {
        isCollected = true;
    }

    public void CorrectIndex(float index)
    {
        this.index = index;
    }
}
