using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableObject : MonoBehaviour
{
	public float movespeed = 5f;
	public float movepointdistance = 0.5f;
	public float blockdistance = 0.2f;
	public float playerdistance = 0.2f;
	public float pushdistance = 0.2f;

	public Transform movepoint;

	public LayerMask blockMovement;
	public LayerMask Playerlayer;
	
	float _vx;
	float _vy;
	public bool pushed;
	
    void Start()
    {
		 movepoint.parent = null;
    }
	
	//void OnCollisionEnter2D(Collision2D other)
	//{
	//	if (other.gameObject.tag == "Player")
	//	{
	//		pushed = true;
	//	}
	//}
	
    void Update()
    {
		_vx = Input.GetAxisRaw ("Horizontal");
		_vy = Input.GetAxisRaw ("Vertical");
		transform.position = Vector3.MoveTowards(transform.position, movepoint.position, movespeed*Time.deltaTime);
		
		if(Physics2D.OverlapCircle(movepoint.position + new Vector3(-_vx*pushdistance,0,0), playerdistance, Playerlayer)||Physics2D.OverlapCircle(movepoint.position + new Vector3(0,-_vy*pushdistance,0), playerdistance, Playerlayer))
		{
			pushed = true;
		}
		
		if(Vector3.Distance(transform.position, movepoint.position) <= movepointdistance)
		{
			if(Mathf.Abs(_vx) == 1f)
			{
				if(pushed == true && !Physics2D.OverlapCircle(movepoint.position + new Vector3(_vx,0,0), blockdistance, blockMovement) && Physics2D.OverlapCircle(movepoint.position + new Vector3(-_vx,0,0), playerdistance, Playerlayer))
				{
					movepoint.position += new Vector3(_vx,0,0);
					pushed = false;
				}
			}
			else if(Mathf.Abs(_vy) == 1f)
			{
				if(pushed == true && !Physics2D.OverlapCircle(movepoint.position + new Vector3(0, _vy,0), blockdistance, blockMovement) && Physics2D.OverlapCircle(movepoint.position + new Vector3(0,-_vy,0), playerdistance, Playerlayer))
				{
					movepoint.position += new Vector3(0,_vy,0);
					pushed = false;
				}
			}
		} 
			}
	}

