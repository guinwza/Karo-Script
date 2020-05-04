using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGate : MonoBehaviour
{
    public GameObject Exit;
	public float ExitDistance = 0.1f;

	public Animator anim;

    bool IsWin;
    
    GridMovementController movementController;
    ReleaseGhost actionController;

    private void Awake() 
    {
        movementController = gameObject.GetComponent<GridMovementController>();
        actionController = gameObject.GetComponent<ReleaseGhost>();


    }
    // Start is called before the first frame update
    void Start()
    {
        Exit = GameObject.FindWithTag("ExitGate");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, Exit.transform.position) <= ExitDistance)
        {
            if(IsWin==false)
            {
                anim.SetTrigger("Win");
                movementController.enabled = false;
                actionController.enabled = false;
                IsWin=true;
            }
        }

    } 
}
