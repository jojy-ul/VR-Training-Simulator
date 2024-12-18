using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerControls : MonoBehaviour
{
   /* static LevelManager levelManager;*/

    [SerializeField]
    VideoPlayer videoPlayer;
    bool isPlaying = false;

    public void PlayPauseVideo()
    {
        isPlaying = !isPlaying;

        if (videoPlayer == null)
            return;

        if (isPlaying)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Pause();
        }
    }

    /*private void Update()
    {
        if (videoPlayer.time == videoPlayer.length)
        {
            levelManager.Tutorial_Scene();
        }
    }*/
}
