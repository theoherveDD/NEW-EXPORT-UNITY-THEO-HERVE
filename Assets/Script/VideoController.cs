using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer; 
    public float playTime = 5f; 
    private float timer = 0f;

    
    private bool hasPlayed = false;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= playTime && !hasPlayed)
        {
            videoPlayer.Play();



            hasPlayed = true; 
        }
    }
}