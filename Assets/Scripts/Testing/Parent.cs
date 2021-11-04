using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{

    public Transform player;
    public Transform car;
    public bool isParenting;

    private void Update()
    {

       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           player.SetParent(car);
            isParenting = true;
        }
    }

    public void GetDown()
    {
        player.SetParent(null);
        isParenting = false;
       
    }


}
