using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private GameObject lastSender;
    public int health = 1;
    public AnimationController anim;
    private void Start()
    {

        GameManager.instance.student.Add(gameObject);
    }
    public void TakeDamage(int amount, GameObject sender, GameObject collision)
    {
        if (sender != lastSender)
        {
            health--;
            lastSender = sender;
            if (health < 0)
            {
                GameManager.instance.student.Remove(this.gameObject);
            }
            else if (collision.GetComponent<Object>().hitDamage)
            {
                anim.HitDamage();
            }
            else anim.LowDamage();

        }
    }

}
