using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoFunction : MonoBehaviour
{
    public GameObject txtStart;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barril")){
            txtStart.SetActive(true);
        }
    }
}
