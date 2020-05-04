using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovementController : MonoBehaviour
{
	public float movespeed = 5f;
	public float movepointdistance = 0.5f;
	public float blockdistance = 0.2f;

	public Transform movepoint;
	public LayerMask blockMovement;
	public Animator anim;
	
		float _vx;
		float _vy;
		bool facingRight = true;
		Transform _transform;

float Speed = 0f;

Vector3 PreviousFramePosition = Vector3.zero;

	void Awake () 
	{
		// get a reference to the components we are going to be changing and store a reference for efficiency purposes
		_transform = GetComponent<Transform> ();
	}
		
    void Start()
    {
        movepoint.parent = null;
    }

    void Update()
    {
		float movementPerFrame = Vector3.Distance (PreviousFramePosition, transform.position) ;
     	Speed = movementPerFrame / Time.deltaTime;
     	PreviousFramePosition = transform.position;

		_vx = Input.GetAxisRaw ("Horizontal");
		_vy = Input.GetAxisRaw ("Vertical");
		transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed*Time.deltaTime);

		if(Vector3.Distance(transform.position, movepoint.position) <= movepointdistance)
		{
			if(Mathf.Abs(Input.GetAxisRaw ("Horizontal")) == 1f)
			{
				if(!Physics2D.OverlapCircle(movepoint.position + new Vector3(_vx,0,0), blockdistance, blockMovement))
				{
					movepoint.position += new Vector3(_vx,0,0);
				}
			}
			else if(Mathf.Abs(Input.GetAxisRaw ("Vertical")) == 1f)
			{
				if(!Physics2D.OverlapCircle(movepoint.position + new Vector3(0, _vy,0), blockdistance, blockMovement))
				{
					movepoint.position += new Vector3(0,_vy,0);
				}
			}
			if(anim && Speed == 0)
			{anim.SetBool("Walk",false);}
		} 
		else 
		{	if(anim)
			{anim.SetBool("Walk",true);}
		}
    }
	
	void LateUpdate()
	{
		// get the current scale
		Vector3 localScale = _transform.localScale;

		if (_vx > 0)
		{
			facingRight = true;
		} else if (_vx < 0)
		{
			facingRight = false;
		}

		// check to see if scale x is right for the player
		// if not, multiple by -1 which is an easy way to flip a sprite
		if (((facingRight) && (localScale.x<0)) || ((!facingRight) && (localScale.x>0))) {
			localScale.x *= -1;
		}

		// update the scale
		_transform.localScale = localScale;
	}


}
