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
        }
        else
        {
            transform.Rotate(0, 0, m_IsRightOpen ? 70 : -70);
            m_IsRightOpen = !m_IsRightOpen;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}