using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoSliderSync : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public Slider timeSlider;

    private bool isDragging = false;

    void Start()
    {
        if (videoPlayer == null || timeSlider == null)
        {
            Debug.LogError("VideoPlayer or Slider reference is missing!");
            return;
        }

        timeSlider.minValue = 0;
        timeSlider.maxValue = 1; // Normalized range (0 to 1)
        timeSlider.onValueChanged.AddListener(OnSliderValueChanged);

        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoEnded;

        if (!videoPlayer.isPrepared)
        {
            videoPlayer.Prepare();
        }
    }

    void Update()
    {
        if (videoPlayer.isPlaying && !isDragging)
        {
            timeSlider.value = (float)(videoPlayer.time / videoPlayer.length);
        }
    }

    private void OnSliderValueChanged(float value)
    {
        if (isDragging)
        {
            videoPlayer.time = value * videoPlayer.length;
        }
    }

    public void OnSliderDragStart()
    {
        isDragging = true;
    }

    public void OnSliderDragEnd()
    {
        isDragging = false;
    }

    private void OnVideoPrepared(VideoPlayer vp)
    {
        timeSlider.value = 0;
    }

    private void OnVideoEnded(VideoPlayer vp)
    {
        timeSlider.value = 0;
    }
}
