using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSelfDestroy : MonoBehaviour
{
    
public LayerMask SleeperLayer;
public float KaroDistance = 0f;
public GameObject movepoint;

public float coolDown = 1f;

float cooldowntimer = 0f;



    void Start()
    {
        
    }

    void Update()
    {
        if(cooldowntimer < coolDown)
        {
            cooldowntimer += Time.deltaTime;
        }

         if (cooldowntimer >= coolDown && Input.GetButton("Fire1") && Physics2D.OverlapCircle(transform.position, KaroDistance, SleeperLayer))
        {
            Destroy(movepoint);
            Destroy(gameObject);
            cooldowntimer = 0;
        }
    }

   
}
