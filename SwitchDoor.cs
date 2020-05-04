using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDoor : MonoBehaviour
{
    public bool Opened;
    public bool PlayerOnTheSwitch1;
    public bool PlayerOnTheSwitch2;
    public bool PlayerOnTheSwitch3;
    public bool PlayerOnTheSwitch4;
    public bool PlayerOnTheSwitch5;
    public bool PlayerOnTheSwitch6;
    public bool PlayerOnTheSwitch7;
    public bool PlayerOnTheSwitch8;
    public bool PlayerOnTheSwitch9;
    public bool PlayerOnTheSwitch10;

    public GameObject Switch1;
    public GameObject Switch2;
    public GameObject Switch3;
    public GameObject Switch4;
    public GameObject Switch5;
    public GameObject Switch6;
    public GameObject Switch7;
    public GameObject Switch8;
    public GameObject Switch9;
    public GameObject Switch10;

    public LayerMask WhatCanBlockDoor;
    public float doorCloseRange = 0.4f;

    BoxCollider2D myCollider;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Switch1 == null){PlayerOnTheSwitch1=true;}
        if(Switch2 == null){PlayerOnTheSwitch2=true;}
        if(Switch3 == null){PlayerOnTheSwitch3=true;}
        if(Switch4 == null){PlayerOnTheSwitch4=true;}
        if(Switch5 == null){PlayerOnTheSwitch5=true;}
        if(Switch6 == null){PlayerOnTheSwitch6=true;}
        if(Switch7 == null){PlayerOnTheSwitch7=true;}
        if(Switch8 == null){PlayerOnTheSwitch8=true;}
        if(Switch9 == null){PlayerOnTheSwitch9=true;}
        if(Switch10 == null){PlayerOnTheSwitch10=true;}

        if((PlayerOnTheSwitch1 && PlayerOnTheSwitch2 && PlayerOnTheSwitch3 && PlayerOnTheSwitch4 && PlayerOnTheSwitch5 && PlayerOnTheSwitch6 && PlayerOnTheSwitch7 && PlayerOnTheSwitch8 && PlayerOnTheSwitch9 && PlayerOnTheSwitch10 ) || Physics2D.OverlapCircle(transform.position, doorCloseRange, WhatCanBlockDoor))
        {
            Opened = true;
        } 
        else
        {
            Opened = false;
        }

        if(Opened)
        {
            myCollider.enabled = false;
        } 
        else if(!Opened)
        {
            myCollider.enabled = true;
        }
    }
}
