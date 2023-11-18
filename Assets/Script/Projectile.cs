using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject pushPos;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Start()
    {
        pushPos = GameObject.FindGameObjectWithTag("PushPos");
        rb.AddForce( pushPos.transform.up *10, ForceMode2D.Impulse);
    }
}
