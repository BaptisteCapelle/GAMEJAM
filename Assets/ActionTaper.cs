using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTaper : Actions
{
    [SerializeField]
    public float power = 10.0F;
    [SerializeField]
    float radiusExplosion = 1f;
    [SerializeField]
    Animation anim1;

    protected override bool GetActionKey()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            anim1.Play();
            return true;
        }
        else
        {
            return false;
        }

        //return Input.GetMouseButtonDown(0);
    }

    protected override void ExecuteAction(RaycastHit resultat)
    {
        resultat.rigidbody.AddExplosionForce(power, resultat.point, radiusExplosion, 3.0F);
    }
}
