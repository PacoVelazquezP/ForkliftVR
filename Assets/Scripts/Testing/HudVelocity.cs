using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Valve.VR.InteractionSystem
{
    public class HudVelocity : MonoBehaviour
    {
        CarController carController;
        [SerializeField] TextMesh countText;
        void Start()
        {
            carController = FindObjectOfType<CarController>();
        }

        // Update is called once per frame
        void Update()
        {
            TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
            countText.text = carController.currentForce.ToString("0");
            
        }
    }
}
