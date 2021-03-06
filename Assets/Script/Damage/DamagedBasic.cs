﻿using UnityEngine;
using System.Collections;

public class DamagedBasic : MonoBehaviour {

    public int health = 1;
    protected  int originalLayer;
    public float invulnTimer = 0;
    public GameObject explostion;
    public bool canExplode = true;

    void Start()
    {
        //sets the original layer to starting layer of object
        originalLayer = gameObject.layer;
    }

    //if unit is hit lose one helth
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag != "Unaffected")
        {
            health--;
        }
    }

    void Update()
    {
        //if health reaches zero call die method.
        if (health <= 0)
        {           
            Die();
        }
    }

    //if called destroy gameobject
    void Die()
    {
        if(canExplode == true)
        { Instantiate(explostion, transform.position, transform.rotation); }
        Destroy(gameObject);
    }
}
