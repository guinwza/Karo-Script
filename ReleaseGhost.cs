using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseGhost : MonoBehaviour
{

public GameObject ghostPrefab;

public bool active;

public float GhostDistance = 0.2f;

public float CameraFollowingSpeed = 5f;

public int LayerNonSleep = 16;
public int LayerSleep = 17;

public Animator anim;

public LayerMask GhostLayer;

public float coolDown = 5f;
public float coolDownforGhost = 1f;

public GameObject ActiveGhost;
public GameObject ActiveGhostMovepoint;
public GameObject MainSceneCamera;


float cooldowntimer = 0f;
float cooldowntimerghost = 0f;
float Speed = 0f;

Vector3 PreviousFramePosition = Vector3.zero;
Vector3 CameraPositionZ = Vector3.zero;

GridMovementController movementController;

    private void Awake()
    {
        movementController = gameObject.GetComponent<GridMovementController>();

        if (!active)
        {
            gameObject.layer = LayerSleep;
            anim.SetBool("Sleep",true);
            cooldowntimerghost = 0;
            movementController.enabled = false;
        }   
    }
    // Start is called before the first frame update
    void Start()
    {
        MainSceneCamera = GameObject.FindWithTag("MainCamera");
        CameraPositionZ = new Vector3(0f,0f,-10f);
       
    }

    // Update is called once per frame
    void Update()
    {
    
     if (!active && !anim.GetBool("Sleep"))
        {
            anim.SetBool("Sleep",true);
        }

    float movementPerFrame = Vector3.Distance (PreviousFramePosition, transform.position) ;
     Speed = movementPerFrame / Time.deltaTime;
     PreviousFramePosition = transform.position;
    
        if(active && ActiveGhost == null)
        {
            ActiveGhostMovepoint = GameObject.FindWithTag("GhostMovePoint");
            ActiveGhost = GameObject.FindWithTag("Ghost");
            ActiveGhost.SetActive(false);
        } else if(!active && ActiveGhost == null)
        {
            ActiveGhostMovepoint = GameObject.FindWithTag("GhostMovePoint");
            ActiveGhost = GameObject.FindWithTag("Ghost");
        }
        if(ActiveGhost){
        if(active && ActiveGhost.activeInHierarchy == false)
        {
            ActiveGhostMovepoint.transform.position = transform.position;
            ActiveGhost.transform.position = transform.position;
            MainSceneCamera.transform.position = transform.position + CameraPositionZ;
        } 
        else if(!active && ActiveGhost.activeInHierarchy == true)
        {
            MainSceneCamera.transform.position = ActiveGhost.transform.position + CameraPositionZ;
        }}

        if(active && cooldowntimerghost < coolDownforGhost)
        {
            cooldowntimerghost += Time.deltaTime;
        }

        if (Input.GetButton("Fire1") && active && cooldowntimerghost >= coolDownforGhost && Speed == 0)
        {
            ActiveGhost.SetActive(true);
            gameObject.layer = LayerSleep;
            anim.SetBool("Sleep",true);
            cooldowntimer = 0;
            movementController.enabled = false;
            active = false;
        }

        if(!active && cooldowntimer < coolDown)
        {
            cooldowntimer += Time.deltaTime;
        }

        if (cooldowntimer >= coolDown && Input.GetButton("Fire1") && !active && Physics2D.OverlapCircle(transform.position, GhostDistance, GhostLayer) && Speed == 0)
        {
            anim.SetBool("Sleep",false);
            cooldowntimerghost = 0;
            movementController.enabled = true;
            active = true;
            ActiveGhost.SetActive(false);
            gameObject.layer = LayerNonSleep;
            //Destroy(ActiveGhost);
        }

    }
}


