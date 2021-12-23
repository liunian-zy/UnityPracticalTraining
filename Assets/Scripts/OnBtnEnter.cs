using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnBtnEnter : MonoBehaviour
{
    private void Start()
    {
        if (gameObject.GetComponent<Animation>() != null)
        {
            gameObject.GetComponent<Animation>().wrapMode = WrapMode.Loop;
        }
    }

    private void OnMouseEnter()
    {
        if (gameObject.GetComponent<Animation>() != null)
        {
            gameObject.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            gameObject.GetComponent<Animation>().Stop();
        }
    }

    private void OnMouseExit()
    {
        if (gameObject.GetComponent<Animation>() != null)
        {
            gameObject.GetComponent<Animation>().Play();
        }
    }
}