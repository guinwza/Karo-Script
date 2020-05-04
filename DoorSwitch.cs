using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public LayerMask WhatCanPressSwitch;
    public GameObject Door;
    public int switchNo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(switchNo == 1)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch1 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch1 = false;
        }
        }
        else  if(switchNo == 2)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch2 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch2 = false;
        }
        }
        else  if(switchNo == 3)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch3 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch3 = false;
        }
        }
        else  if(switchNo == 4)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch4 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch4 = false;
        }
        }
        else  if(switchNo == 5)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch5 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch5 = false;
        }
        }
        else  if(switchNo == 6)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch6 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch6 = false;
        }
        }
        else  if(switchNo == 7)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch7 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch7 = false;
        }
        }        else  if(switchNo == 8)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch8 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch8 = false;
        }
        }        else  if(switchNo == 9)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch9 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch9 = false;
        }
        }        else  if(switchNo == 10)
        {
        if(Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch10 = true;
        }
        else if(!Physics2D.OverlapCircle(transform.position, 0, WhatCanPressSwitch))
        {
            Door.GetComponent<SwitchDoor>().PlayerOnTheSwitch10 = false;
        }
        }
    }
}
