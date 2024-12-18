using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSolder : MonoBehaviour
{
    [SerializeField]
    ParticleSystem Smoke;

    [SerializeField]
    AudioSource AudioSource;

    [SerializeField]
    AudioSource AudioSource2;

    [SerializeField]
    GameObject Wire1;
    [SerializeField]
    GameObject Wire2;
    [SerializeField]
    GameObject Solder;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Wire")
        {
            Smoke.Play();
            AudioSource.Play();
            Debug.Log("Entered");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Wire")
        {
            Smoke.Stop();
            Wire1.transform.SetParent(Wire2.transform);
            Solder.SetActive(true);
            AudioSource.Stop();
            AudioSource2.Play();
        }

    }


}
