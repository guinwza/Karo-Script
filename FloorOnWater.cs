using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorOnWater : MonoBehaviour
{
    public int LayerWater;
    public int LayerFloor;
    public LayerMask FloorLayer;

    void Start()
    {
        
    }

    void Update()
    {
            if (Physics2D.OverlapCircle(transform.position, 0, FloorLayer))
            {
                gameObject.layer = LayerFloor;
            } else if (!Physics2D.OverlapCircle(transform.position, 0, FloorLayer))

            {
                gameObject.layer = LayerWater;
            }
    }
}
