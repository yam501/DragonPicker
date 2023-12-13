using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CheckConnectYG : MonoBehaviour
{
    private void OnEnable() => YandexGame.GetDataEvent += CheckSDK;
    

    private void OnDisable() => YandexGame.GetDataEvent  -= CheckSDK;

    void Start()
    {
        if (YandexGame.SDKEnabled ==  true)
        {
           CheckSDK();
        }
    }

    public void CheckSDK()
    {
        if (YandexGame.auth == true)
        {
            Debug.Log("User is auth");
        }
        else
        {
            Debug.Log("User not auth");
            YandexGame.AuthDialog();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
