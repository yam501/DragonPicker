using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class CheckConnectYG : MonoBehaviour
{
    public TextMeshProUGUI scoreBest;
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
        YandexGame.RewVideoShow(0);
        GameObject scoreBEST = GameObject.Find("BestScore");
        scoreBest = scoreBEST.GetComponent<TextMeshProUGUI>();
        scoreBest.text = "Best score: " + YandexGame.savesData.bestScore.ToString();
        // if ((YandexGame.savesData.achivment)[0] == null & GameObject.Find("ListAchiv"))
        // {
        //     
        // }
        // else
        // {
            foreach (string value in YandexGame.savesData.achivment)
            {
                GameObject.Find("ListAchiv").GetComponent<TextMeshProUGUI>().text = GameObject.Find("ListAchiv").GetComponent<TextMeshProUGUI>().text + value + '\n';
            }
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
