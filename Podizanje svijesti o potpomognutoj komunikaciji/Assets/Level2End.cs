using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Level2End : MonoBehaviour
    {

    public GameObject CorrectImage1;
    public GameObject CorrectImage2;
    public GameObject CorrectImage3;

    public GameObject Arrow;
    public GameObject LevelEnd;

    public void Start ()
    {
        if (CorrectImage1.activeSelf && CorrectImage2.activeSelf && CorrectImage3.activeSelf)
        {
            Arrow.SetActive(true);
            LevelEnd.SetActive(true);
        }
    }
}

