using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseFrontCover : MonoBehaviour
{
    private bool m_IsOpen;

    // Start is called before the first frame update
    void Start()
    {
        m_IsOpen = false;
    }

    /// <summary>
    /// ¿ª¹ØÇ°²Õ¸Ç
    /// </summary>
    public void Open()
    {
        transform.Rotate(m_IsOpen ? -10 : 10, 0, 0);
        m_IsOpen = !m_IsOpen;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
