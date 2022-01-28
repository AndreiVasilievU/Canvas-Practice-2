using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public ButtonController[] buttonControllers;
    public GameObject[] secondCanvases;

    public static int btnNumber;

    public void DisableBtns()
    {
        for (int i = 0; i < buttonControllers.Length; i++)
        {
            if (i == btnNumber)
            {
                buttonControllers[i].OnScaleBtn();
                secondCanvases[i].SetActive(true);
            }
            else
            {
                buttonControllers[i].OffScaleBtn();
                secondCanvases[i].SetActive(false);
            }
        }
    }
}
