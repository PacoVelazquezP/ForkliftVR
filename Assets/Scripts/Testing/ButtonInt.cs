using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Valve.VR.InteractionSystem;
using Valve.VR;

    public class ButtonInt : MonoBehaviour
    {
        public HoverButton hoverButton;
        public CarController carController;

        private void Start()
        {
            this.hoverButton.onButtonDown.AddListener(OnButtonDown);
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(DoMove());
        }


        private IEnumerator DoMove()
        {
            //movePosition = FindObjectOfType<MovePosition>();
            this.carController.ForMove();

           

            yield return null;
        }
}

