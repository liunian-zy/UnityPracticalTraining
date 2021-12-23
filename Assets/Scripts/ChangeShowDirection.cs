using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShowDirection : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Change()
    {
        var find = GameObject.Find("GameObject");
        switch (transform.name)
        {
            case "LeftButton":
                find.transform.position = new Vector3(-6,0,0);
                find.transform.rotation = Quaternion.Euler(0,0,0);
                GlobalVars.Global.currentScreen = 0;
                break; 
            case "RightButton":
                find.transform.position = Vector3.zero;
                find.transform.rotation = Quaternion.Euler(0,180,0);
                GlobalVars.Global.currentScreen = 1;
                break;
            case "FrontButton":
                find.transform.position = new Vector3(-3,0,-2);
                find.transform.rotation = Quaternion.Euler(0,-90,0);
                GlobalVars.Global.currentScreen = 2;
                break;
            case "BackButton":
                find.transform.position = new Vector3(-3,0,5);
                find.transform.rotation = Quaternion.Euler(0,90,0);
                GlobalVars.Global.currentScreen = 3;
                break;
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
