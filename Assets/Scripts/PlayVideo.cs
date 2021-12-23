using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public GameObject video;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void play()
    {
        video.SetActive(true);
        video.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
    }
}