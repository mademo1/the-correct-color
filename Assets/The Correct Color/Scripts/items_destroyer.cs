﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items_destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
