using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateHud : MonoBehaviour
{
    public GameObject txtCarryBox;
    SpawnObj spawnObj;

    void Start()
    {
        spawnObj = GetComponent<SpawnObj>();
        spawnObj = FindObjectOfType<SpawnObj>();
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boxes"))
        {
            txtCarryBox.SetActive(true);
            spawnObj.NewTimeToTrail();
        }
    }
}
