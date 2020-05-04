using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    public int selectedSkin;

    private SpriteRenderer spriteR;
    private Sprite sprites;

    Animator animator;

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        sprites = Resources.Load<Sprite>("Assets/Sprites/Karo_Origin_Sleep_Idle_Walk");

        animator = gameObject.GetComponent<Animator>();

    }



    void Update()
    { 
        if(selectedSkin == 0)
        {
        animator.runtimeAnimatorController = Resources.Load("Karo_Normal/Karo") as RuntimeAnimatorController;
        }
        if(selectedSkin == 1)
        {
        animator.runtimeAnimatorController = Resources.Load("Karo_Origin/Karo_Sleep_2") as RuntimeAnimatorController;
        }
    }
}
