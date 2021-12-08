using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField account;
    public InputField password;
    public Text msg;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onClick()
    {
        if(string.IsNullOrEmpty(account.text) || string.IsNullOrEmpty(password.text))
        {
            msg.text = "�������˺ź�����";
        }
        else
        {
            msg.color = UnityEngine.Color.green;
            msg.text = "��¼�ɹ���3�����ת...";
            Invoke("ChangeScene",3);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("Scenes/CarShow");
    }
}
