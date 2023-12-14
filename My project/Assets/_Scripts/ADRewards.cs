using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using YG;
using YG.Example;
using Random = UnityEngine.Random;

public class ADRewards : MonoBehaviour
{
    private void OnEnable() => YandexGame.CloseVideoEvent += Rewarded;

    private void OnDisable() => YandexGame.CloseVideoEvent -= Rewarded;

    void Rewarded()
    {
        Debug.Log("Награда");
    }

    public void OpenAD()
    {
        YandexGame.RewVideoShow(Random.Range(0,2));
    }
}