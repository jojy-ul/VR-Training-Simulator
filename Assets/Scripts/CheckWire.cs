using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWire : MonoBehaviour
{
    [SerializeField]
    AudioSource AudioSource;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Wire")
        {
            if(!AudioSource.isPlaying)
            AudioSource.Play();
        }
    }
}
