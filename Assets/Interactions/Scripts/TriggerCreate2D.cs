using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCreate2D : MonoBehaviour
{
    public GameObject EndroitOuSpawner;
    public GameObject ObjetACreer;
    public string TagADetecter;
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == TagADetecter)
        {
            Instantiate(ObjetACreer, EndroitOuSpawner.transform.position, EndroitOuSpawner.transform.rotation);
        }
    }
}

