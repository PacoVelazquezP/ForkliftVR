using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class AudioManager : MonoBehaviour
    {
        public AudioSource Forklift_AS;

        public AudioClip turnOn;
        public AudioClip turnOff;
        public AudioClip going;


        private void Awake()
        {
            Forklift_AS = GetComponentInChildren<AudioSource>();

        }

        public void PlayLoopWalk()
        {
            Forklift_AS.loop = true;
            Forklift_AS.clip = going;
            Forklift_AS.pitch = 1.3f;
            if (Forklift_AS != Forklift_AS.isPlaying)
            {
                Forklift_AS.Play();
            }
        }

        public void StopLoop()
        {
            Forklift_AS.loop = false;
            Forklift_AS.Stop();
        }

        public void PlayStart()
        {
            Forklift_AS.PlayOneShot(turnOn);
        }

        public void PlayStop()
        {
            Forklift_AS.PlayOneShot(turnOff);
        }


    }
}
