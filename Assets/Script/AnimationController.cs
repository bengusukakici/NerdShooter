using System.Collections;
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

    }
    public void DangerFalse()
    {
        GameManager.instance.isDanger = false;
    }
    public void DangerTrue()
    {
        GameManager.instance.isDanger = true;
    }
}
