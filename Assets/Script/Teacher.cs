using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    private GameObject lastSender;
    public int health = 3;
    public AnimationController anim;

    void Start()
    {
        //InvokeRepeating("SetAnimation", 5.0f, health * 2);
        StartCoroutine(SetAnimationC());

    }

    void Update()
    {
    }
    //public void SetAnimation()
    //{
    //    anim.Idle();
    //    Debug.Log("deneme");
    //    StartCoroutine(SetAnimationC());
    //}
    
    public IEnumerator SetAnimationC()
    {
        yield return new WaitForSeconds(health * 3);
        anim.Idle();
        StartCoroutine(SetAnimationC());
    }
    public void TakeDamage(int amount, GameObject sender, GameObject collision)
    {
        if (sender != lastSender && health > 3)
        {
            health--;
            lastSender = sender;
            //anim.Idle();
            Debug.Log(health);
            
        }
    }
}
