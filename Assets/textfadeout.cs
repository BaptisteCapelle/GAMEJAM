using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textfadeout : MonoBehaviour
{
    public float lifetime = 13;
    public void Start()
    {
        Destroy(this.gameObject, lifetime);
    }
}
