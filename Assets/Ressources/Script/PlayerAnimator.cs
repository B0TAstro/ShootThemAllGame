using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    // References to the animator and the player mouvement script
    Animator am;
    PlayerMouvement pm;
    SpriteRenderer[] childSpriteRenderers;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMouvement>();
        childSpriteRenderers = GetComponentsInChildren<SpriteRenderer>();
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
        bool shouldFlip = pm.lastHorizontalVector > 0;

        foreach (SpriteRenderer sr in childSpriteRenderers)
        {
            sr.flipX = shouldFlip;
        }
    }
}