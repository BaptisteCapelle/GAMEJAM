using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pisser : MonoBehaviour
    
    
{
    [SerializeField]
    float radius = 10f;
    [SerializeField]
    float distance = 10f;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            //(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = Mathf.Infinity
            RaycastHit[] hitResults = Physics.SphereCastAll(transform.position + transform.forward, radius, transform.forward, distance);

            if (hitResults != null && hitResults.Length > 0)
            {

                foreach (RaycastHit resultat in hitResults)
                {

                    if (resultat.transform.gameObject.CompareTag("wall"))
                        Debug.Log(resultat.transform.name);

                    // Update is called once per frame

                }

            }
        }
    }
}
