using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{   
    public LayerMask Key;
    public int OpenedDoorLayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0, Key))
        {
            gameObject.layer = OpenedDoorLayer;
        }

    }
}
