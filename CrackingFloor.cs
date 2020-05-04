using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackingFloor : MonoBehaviour
{
    public int LayerHole;
    public int LayerFloor;
    public LayerMask PlayerLayer;
    public float CrackDistance = 0.1f;
    public bool stepped;
    public bool cracked;
    public bool crackedToWater;
    public LayerMask FloorLayer;


    void Start()
    {
        
    }

    void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 0, PlayerLayer))
        {
            stepped = true;
        }

        if (Physics2D.OverlapCircle(transform.position, 0, PlayerLayer) && stepped == true)
        {
            cracked = false;
        } 
        else if (!Physics2D.OverlapCircle(transform.position, CrackDistance, PlayerLayer) && stepped == true && cracked == false &&  gameObject.layer != LayerHole)
        {
            cracked = true;
            gameObject.layer = LayerHole;
        }
        else if (cracked == false && stepped == false)
        {
            gameObject.layer = LayerFloor;
        }
        else if (crackedToWater && Physics2D.OverlapCircle(transform.position, 0, FloorLayer) && gameObject.layer == LayerHole)
        {
            gameObject.layer = LayerFloor;
        }

    }
}
