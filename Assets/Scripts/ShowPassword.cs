using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPassword : MonoBehaviour
{
    public InputField password;
    // Start is called before the first frame update
    void Start()
    {
        ChangePasswordShow(GetComponent<Toggle>().isOn);
    }
    public void ChangePasswordShow(bool isOn)
    {
        password.contentType = isOn ? InputField.ContentType.Standard : InputField.ContentType.Password;
        password.Select();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
