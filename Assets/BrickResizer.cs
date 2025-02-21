using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickResizer : MonoBehaviour
{
    public Vector2 referenceResolution = new Vector2(1920, 1080); //referans

    void Start()
    {
        ResizeBricks();
    }

    void ResizeBricks()
    {
        float widthRatio = Screen.width / referenceResolution.x;
        float heightRatio = Screen.height / referenceResolution.y;
        float scaleFactor = Mathf.Min(widthRatio, heightRatio); 

        GameObject[] bricks = GameObject.FindGameObjectsWithTag("brick");
        foreach (GameObject brick in bricks)
        {
            brick.transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
        }
    }
}