
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource _AudioSource;
    [SerializeField]
    AudioSource _GogglesAudioSource;
    [SerializeField]
    AudioSource _LabcoatAudioSource;
    [SerializeField]
    AudioSource _FinalAudioSource;
    bool _isPlayed = false;


    [SerializeField]
    GameObject _Goggles;
    [SerializeField]
    GameObject _Labcoat;

    bool B_goggles, B_labcoat;


    private void Start()
    {
        B_goggles = _Goggles.GetComponent<Toggle>().isOn;
        B_labcoat = _Labcoat.GetComponent<Toggle>().isOn;
    }

    
    public void PlayWelcomeAudio()
    {
        if (!_isPlayed)
        {
            _AudioSource.Play();
            _isPlayed = true;
        }
        
    } 

    public void Saftey_Googles()
    {
        if (!_AudioSource.isPlaying && !_LabcoatAudioSource.isPlaying)
        {
            _GogglesAudioSource.Play();
        }    
    }

    public void Saftey_Labcoat()
    {
        if (!_AudioSource.isPlaying && !_GogglesAudioSource.isPlaying)
        {
            _LabcoatAudioSource.Play();
        }
    }

    private void Update()
    {
        B_goggles = _Goggles.GetComponent<Toggle>().isOn;
        B_labcoat = _Labcoat.GetComponent<Toggle>().isOn;
        if (B_goggles && B_labcoat && !_AudioSource.isPlaying && !_GogglesAudioSource.isPlaying && !_LabcoatAudioSource.isPlaying)
        {
            _FinalAudioSource.Play();
            if (!_FinalAudioSource.isPlaying)
            {
                SceneManager.LoadScene("Equipment_Familiarization");
            }
        }
    }
}
