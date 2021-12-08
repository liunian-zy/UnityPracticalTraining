using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseTrunk : MonoBehaviour
{
    private bool m_IsOpen;

    // Start is called before the first frame update
    void Start()
    {
        m_IsOpen = false;
    }

    /// <summary>
    /// 开关后备箱
    /// </summary>
    public void Open()
    {
        transform.Rotate(m_IsOpen ? 60 : -60, 0, 0);
        m_IsOpen = !m_IsOpen;
    }

    // Update is called once per frame
    void Update()
    {
    }
}