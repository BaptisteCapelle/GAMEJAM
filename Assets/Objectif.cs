using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : Actions
{
    public AudioClip cadre;
    protected override void ExecuteAction(RaycastHit resultat)
    {
        Debug.Log(resultat.transform.name);
        AudioSource.PlayClipAtPoint(cadre, gameObject.transform.position);
        resultat.rigidbody.gameObject.SetActive(false);
        objectif5 = objectif5 + 1;

        if (objectif5 == 7)
        {
            Debug.Log("GAGNE");
        }

    }

    int objectif5;
    protected override bool GetActionKey()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
