using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public LayerMask WhatDestroyKey;
    public LayerMask KeyDoor;
    public int LayerFloor;

    PushableObject movementController;

    private void Awake() 
    {
        movementController = gameObject.GetComponent<PushableObject>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0, WhatDestroyKey))
        {
            movementController.enabled = false;
            gameObject.SetActive(false);
        }
        if (Physics2D.OverlapCircle(transform.position, 0, KeyDoor))
        {
            gameObject.layer = LayerFloor;
            movementController.enabled = false;
        }

    }
}
