using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToDetail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void go()
    {
        SceneManager.LoadScene("Scenes/Detail");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
