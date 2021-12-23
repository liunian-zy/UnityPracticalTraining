using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShowInit : MonoBehaviour
{
    public static MeshRenderer[] _meshRenderers;
    // Start is called before the first frame update
    void Start()
    {
        var find1 = GameObject.Find("ЭтЪЮ");
        // GameObject
        var meshRenderer = find1.GetComponentsInChildren<MeshRenderer>();
        _meshRenderers = meshRenderer;
        // print(_meshRenderers);
        // print(111);
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
