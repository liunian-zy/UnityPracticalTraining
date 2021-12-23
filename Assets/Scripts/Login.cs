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
        if (string.IsNullOrEmpty(account.text) || string.IsNullOrEmpty(password.text))
        {
            msg.text = "«Î ‰»Î’À∫≈∫Õ√‹¬Î";
        }
        else
        {
            if (account.text != "admin" && password.text != "admin")
            {
                msg.color = UnityEngine.Color.red;
                msg.text = "µ«¬º ß∞‹«ÎºÏ≤È’À∫≈ªÚ√‹¬Î";
            }
            else
            {
                msg.color = UnityEngine.Color.green;
                msg.text = "µ«¬º≥…π¶£°3√Î∫ÛÃ¯◊™...";
                Invoke("ChangeScene", 3);
            }
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