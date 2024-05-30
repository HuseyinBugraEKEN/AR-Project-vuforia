using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    private ObserverBehaviour mObserverBehaviour;
    private VideoPlayer videoPlayer;
    private AudioSource audioSource;

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnObserverStatusChanged;
        }

        // plane nesnesi altındaki VideoPlayer bileşenini bulun
        videoPlayer = GetComponentInChildren<VideoPlayer>();
        
        // plane nesnesi altındaki AudioSource bileşenini bulun
        audioSource = GetComponentInChildren<AudioSource>();
    }

    private void OnDestroy()
    {
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged -= OnObserverStatusChanged;
        }
    }

    private void OnObserverStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED ||
            targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            OnTrackingFound();
        }
        else
        {
            OnTrackingLost();
        }
    }

    private void OnTrackingFound()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
            if (audioSource != null)
            {
                audioSource.Play(); // Sesi devam ettir
            }
        }
    }

    private void OnTrackingLost()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Pause(); // Videoyu duraklat
            if (audioSource != null)
            {
                audioSource.Pause(); // Sesi duraklat
            }
        }
    }
}

