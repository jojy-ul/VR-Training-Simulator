using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioTutorial : MonoBehaviour
{
    [SerializeField]
    AudioSource _AudioSource;
    bool _isPlayed = false;


   
    public void PlayWelcomeAudio()
    {
        if (!_isPlayed)
        {
            _AudioSource.Play();
            _isPlayed = true;
        }

    }
}
