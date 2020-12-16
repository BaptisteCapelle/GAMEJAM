using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actions : MonoBehaviour
{
    [SerializeField]
    float radius = 1f;
    [SerializeField]
    float distance = 0.4f;
    [SerializeField]
    string targetTag;


    private void Update()
    {
        if (GetActionKey()) //if Input.GetMouseButtonDown(0);
        {
            //(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = Mathf.Infinity
            RaycastHit[] hitResults = Physics.SphereCastAll(transform.position + transform.forward, radius, transform.forward, distance);

            if (hitResults != null && hitResults.Length > 0)
            {
                foreach (RaycastHit resultat in hitResults)
                {
                    if (resultat.transform.gameObject.CompareTag(targetTag))
                    {
                        ExecuteAction(resultat);
                    }
                }
            }
        }
    }
    //private
    //protected
    //public
    protected abstract bool GetActionKey();
    protected abstract void ExecuteAction(RaycastHit resultat);

}

