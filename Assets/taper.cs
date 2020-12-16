using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taper : MonoBehaviour
{
    [SerializeField]
    float radius = 1f;
    [SerializeField]
    float radiusExplosion = 1f;
    
    [SerializeField]
    float distance = 10f;
    [SerializeField]
    public float power = 10.0F;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = Mathf.Infinity
            RaycastHit[] hitResults = Physics.SphereCastAll(transform.position + transform.forward, radius, transform.forward, distance);

            if (hitResults != null && hitResults.Length > 0)
            {

                foreach (RaycastHit resultat in hitResults)
                {
                
                    if (resultat.transform.gameObject.CompareTag("Finish"))
                    {
                        Debug.Log(resultat.transform.name);
                        resultat.rigidbody.AddExplosionForce(power, resultat.point, radiusExplosion, 3.0F);
                        //resultat.rigidbody 
                    }
                }
            }
        }
    }

}

