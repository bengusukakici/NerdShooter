using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public List<GameObject> obj;
    public List<GameObject> student;
    public GameObject shootObj;
    public Shoot shootscript;

    public GameObject hold;
    public bool isHold;
    public bool isDanger;
    public bool isFinal;


    public ParticleSystem Explosion;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        shootscript = FindObjectOfType<Shoot>();
    }
    void Start()
    {
        isHold = false;
        isDanger = false;
        shootscript.enabled = false;
    }
}
