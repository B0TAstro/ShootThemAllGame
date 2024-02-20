using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // References to the animator and the player mouvement script
    Animator am;
    PlayerMouvement pm;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMouvement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDirection.x != 0 || pm.moveDirection.y != 0)
        {
            am.SetBool("Move", true);
            DirectionCheck();
        }
        else
        {
            am.SetBool("Move", false);
        }
    }

    void DirectionCheck()
    {
        if (pm.moveDirection.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}