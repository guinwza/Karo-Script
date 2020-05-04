using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPushedIntoWater : MonoBehaviour
{

    public int LayerFloor;
    public int LayerHole;

    public LayerMask WaterLayer;
    public LayerMask HoleLayer;

    float Speed = 0f;

    PushableObject movementController;
    Vector3 PreviousFramePosition = Vector3.zero;

    private void Awake() 
    {
        movementController = gameObject.GetComponent<PushableObject>();

    }

    void Start()
    {
        
    }

    void Update()
    {
        float movementPerFrame = Vector3.Distance (PreviousFramePosition, transform.position) ;
        Speed = movementPerFrame / Time.deltaTime;
        PreviousFramePosition = transform.position;

            if (Physics2D.OverlapCircle(transform.position, 0, WaterLayer) && Speed == 0)
            {
                gameObject.layer = LayerFloor;
                movementController.enabled = false;
            }
            if (Physics2D.OverlapCircle(transform.position, 0, HoleLayer) && Speed == 0)
            {
                gameObject.layer = LayerHole;
                movementController.enabled = false;
            }
    }
}
