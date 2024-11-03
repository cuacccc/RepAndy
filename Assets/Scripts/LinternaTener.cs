using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaTener : MonoBehaviour
{
    public GameObject Linterna;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Linterna.SetActive(true);
            Linterna.GetComponent<Linterna>().LinternaEnMano = true;
            Destroy(gameObject);
        }


    }
}
