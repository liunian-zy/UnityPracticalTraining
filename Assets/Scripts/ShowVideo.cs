using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

/// <summary>
/// Jerry代码编写
/// </summary>
public class ShowVideo : MonoBehaviour
{
    //设置VideoPlayer、RawImage和当前播放视频索引参数
    private VideoPlayer videoPlayer;
    private RawImage rawImage;

    private int currentClipIndex;

    //设置相关文本和按钮参数以及视频列表
    public Button button_Start;
    public Button button_Pause;
    public Button button_Restart;
    public Button button_Close;
    public VideoClip[] videoClips;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Detail")
        {
            //获取VideoPlayer和RawImage组件，以及初始化当前视频索引
            videoPlayer = this.GetComponent<VideoPlayer>();
            rawImage = this.GetComponent<RawImage>();
            currentClipIndex = GlobalVars.Global.currentScreen;
            videoPlayer.clip = videoClips[currentClipIndex];
            //设置相关按钮监听事件
            button_Start.onClick.AddListener(OnStartVideo);
            button_Pause.onClick.AddListener(OnPauseVideo);
            button_Restart.onClick.AddListener(OnRestartVideo);
            button_Close.onClick.AddListener(OnCloseVideo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Detail")
        {
            //没有视频则返回，不播放
            if (videoPlayer.texture == null)
            {
                return;
            }

            //渲染视频到UGUI上
            rawImage.texture = videoPlayer.texture;
        }
    }

    /// <summary>
    /// 播放和暂停当前视频
    /// </summary>
    private void OnStartVideo()
    {
        videoPlayer.Play();
    }

    /// <summary>
    /// 切换上一个视频
    /// </summary>
    private void OnPauseVideo()
    {
        videoPlayer.Pause();
    }

    /// <summary>
    /// 切换下一个视频
    /// </summary>
    private void OnRestartVideo()
    {
        videoPlayer.time = 0;
        videoPlayer.Play();
    }

    private void OnCloseVideo()
    {
        var find = GameObject.Find("Video");
        print(find);
        find.SetActive(false);
        videoPlayer.Stop();
    }
}