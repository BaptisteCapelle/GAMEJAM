﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maou : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip miaulement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
            AudioSource.PlayClipAtPoint(miaulement, gameObject.transform.position);
    }
}
