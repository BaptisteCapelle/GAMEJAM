using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGriffer : Actions
{
    [SerializeField]
    Animation anim2;
    [SerializeField]
    GameObject prefabGriffure;
    public AudioClip bruitgriffer;
    protected override void ExecuteAction(RaycastHit resultat)
    {
        Debug.Log(resultat.transform.name);
        AudioSource.PlayClipAtPoint(bruitgriffer, gameObject.transform.position);
        anim2.Stop();
        anim2.Play();
        Instantiate(prefabGriffure, resultat.point, Quaternion.LookRotation(resultat.normal, Vector3.up));
    }

    protected override bool GetActionKey()
    {
        if (Input.GetMouseButtonDown(1) == true)
        {
            
            return true;
        }
        else
        {
            return false;
        }



    }

   
}
