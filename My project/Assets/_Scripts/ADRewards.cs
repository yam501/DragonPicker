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

    void Rewarded(int id)
    {
        if (id == 1)
        {
            Debug.Log("Награда");
        }
        else
        {
            Debug.Log("Без награды");

        }
    }

    public void OpenAD()
    {
        YandexGame.RewVideoShow(Random.Range(0,2));
    }
}