using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionGriffer : Actions
{
    protected override void ExecuteAction(RaycastHit resultat)
    {
        Debug.Log(resultat.transform.name);
    }

    protected override bool GetActionKey()
    {
        if (Input.GetKeyDown(KeyCode.X) == true)
        {
            return true;
        }
        else
        {
            return false;
        }



    }

   
}
