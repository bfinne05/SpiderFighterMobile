using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public LineRenderer[] lineRenderers;
    public Transform[] linePositions;
    public Transform center;
    public Transform idlePosition;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderers[0].positionCount = 2;
        lineRenderers[1].positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
