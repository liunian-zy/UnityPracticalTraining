using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseDoor : MonoBehaviour
{
    private bool m_IsLeftOpen;
    private bool m_IsRightOpen;

    // Start is called before the first frame update
    void Start()
    {
        m_IsLeftOpen = false;
        m_IsRightOpen = false;
    }

    /// <summary>
    /// 开关车门
    /// </summary>
    public void Open()
    {
        if (transform.name == "LeftDoor")
        {
            transform.Rotate(0, 0, m_IsLeftOpen ? -70 : 70);
            m_IsLeftOpen = !m_IsLeftOpen;
            var find1 = GameObject.Find("外饰");
            // GameObject
            var meshRenderer = find1.GetComponentsInChildren<MeshRenderer>();
            foreach (var meshRenderer1 in meshRenderer)
            {
                print(meshRenderer1);
                meshRenderer1.material = Resources.Load("20 - Defaultsds") as Material;
            }
        }
        else
        {
            transform.Rotate(0, 0, m_IsRightOpen ? 70 : -70);
            m_IsRightOpen = !m_IsRightOpen;
            // foreach (var mesh in CarShowInit._meshRenderers)
            // {
            //     mesh.material = mesh.material;
            // }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}