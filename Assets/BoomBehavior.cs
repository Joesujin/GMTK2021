﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animationOver()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
