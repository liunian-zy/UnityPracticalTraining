using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartMove()
    {
        print("move");
        transform.Rotate(-Vector3.up*20*Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
