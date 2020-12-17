using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectif : Actions
{
    public AudioClip cadre;
    [SerializeField]
    public TextMesh textfin;

    public float lifetime = 8;
    protected override void ExecuteAction(RaycastHit resultat)
    {
        Debug.Log(resultat.transform.name);
        AudioSource.PlayClipAtPoint(cadre, gameObject.transform.position);
        resultat.rigidbody.gameObject.SetActive(false);
        objectif5 = objectif5 + 1;

        if (objectif5 == 5)
        {
            textfin.gameObject.SetActive(true);

            StartCoroutine(LateCall());
        }

        IEnumerator LateCall()
        {

            yield return new WaitForSeconds(lifetime);

            textfin.gameObject.SetActive(false);
            //Do Function here...
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
