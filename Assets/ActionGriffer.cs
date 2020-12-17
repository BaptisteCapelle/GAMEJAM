using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGriffer : Actions
{
    [SerializeField]
    GameObject prefabGriffure;
    protected override void ExecuteAction(RaycastHit resultat)
    {
        Debug.Log(resultat.transform.name);
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
