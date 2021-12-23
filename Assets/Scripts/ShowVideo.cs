using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

/// <summary>
/// Jerry�����д
/// </summary>
public class ShowVideo : MonoBehaviour
{
    //����VideoPlayer��RawImage�͵�ǰ������Ƶ��������
    private VideoPlayer videoPlayer;
    private RawImage rawImage;

    private int currentClipIndex;

    //��������ı��Ͱ�ť�����Լ���Ƶ�б�
    public Button button_Start;
    public Button button_Pause;
    public Button button_Restart;
    public Button button_Close;
    public VideoClip[] videoClips;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Detail")
        {
            //��ȡVideoPlayer��RawImage������Լ���ʼ����ǰ��Ƶ����
            videoPlayer = this.GetComponent<VideoPlayer>();
            rawImage = this.GetComponent<RawImage>();
            currentClipIndex = GlobalVars.Global.currentScreen;
            videoPlayer.clip = videoClips[currentClipIndex];
            //������ذ�ť�����¼�
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
            //û����Ƶ�򷵻أ�������
            if (videoPlayer.texture == null)
            {
                return;
            }

            //��Ⱦ��Ƶ��UGUI��
            rawImage.texture = videoPlayer.texture;
        }
    }

    /// <summary>
    /// ���ź���ͣ��ǰ��Ƶ
    /// </summary>
    private void OnStartVideo()
    {
        videoPlayer.Play();
    }

    /// <summary>
    /// �л���һ����Ƶ
    /// </summary>
    private void OnPauseVideo()
    {
        videoPlayer.Pause();
    }

    /// <summary>
    /// �л���һ����Ƶ
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