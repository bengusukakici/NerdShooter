﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController instance;
    [SerializeField] Animator animator;

    private void Awake()
    {
        if (instance != null)
            instance = this;
    }
    void Start()
    {
    }
    void Update()
    {

    }
    public void HitDamage()
    {
        animator.SetTrigger("hitDamage");
    }
    public void LowDamage()
    {
        animator.SetTrigger("lowDamage");
    }
    public void Idle()
    {
        animator.SetTrigger("isIdle");

        GameManager.instance.isDanger = true;
    }
    public void Idle2()
    {
        GameManager.instance.isDanger = false;
    }
}
