using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : MonoBehaviour
{
    private GameObject lastSender;
    public int Damage = 3;
    public int health = 2;
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
        Debug.Log("say");

        yield return new WaitForSeconds(Damage * 3);

        Debug.Log("say2");
        anim.Idle();
        StartCoroutine(SetAnimationC());
    }
    public void TakeDamage(int amount, GameObject sender, GameObject collision)
    {
        if (sender != lastSender)
        {
            Damage--;
            lastSender = sender;
            //anim.Idle();
            //Debug.Log(Damage);

        }
    }
    public void TakeHealth(int amount, GameObject sender, GameObject collision)
    {
        if (sender != lastSender)
        {
            health--;
            lastSender = sender;
            //anim.Idle();
            //Debug.Log(health);
            if (health < 0)
            {
                Debug.Log("winnn");
            }
        }
    }
}
