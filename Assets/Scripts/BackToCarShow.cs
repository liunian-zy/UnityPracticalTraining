using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToCarShow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void back()
    {

        SceneManager.LoadScene("Scenes/CarShow");
    }

    // Update is called once per frame
    void Update()
    {
    }
}