using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject[] coins;
    [SerializeField] private Button btn;
    [SerializeField] private GameObject cursor;
    [SerializeField] private Game game;

    private bool isActiveBtn;
    public bool isScale;
    public float scaleValue = 0;

    private void Start()
    {
        foreach (var VARIABLE in coins)
        {
            VARIABLE.SetActive(false);
        }
    }

    private void Update()
    {
        if (isScale == true)
        {
            OnScaleBtn();
        }
        else
        {
            OffScaleBtn();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && isActiveBtn == true)
        {
            ActiveCoins(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && isActiveBtn == true)
        {
            ActiveCoins(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && isActiveBtn == true)
        {
            ActiveCoins(3);
        }
        
    }

    public void OnScaleBtn()
    {
        if (scaleValue >= 1)
        {
            isActiveBtn = true;
            return;
        }

        isScale = true;
        btn.interactable = false;
        cursor.SetActive(true);
        scaleValue += 0.7f * Time.deltaTime;
        transform.localScale = Vector3.Lerp(Vector3.one, new Vector3(2, 2, 2), scaleValue);
    }

    public void OffScaleBtn()
    {
        if (scaleValue <= 0)
        {
            btn.interactable = true;
            return;
        }

        isActiveBtn = false;
        isScale = false;
        cursor.SetActive(false);
        scaleValue -= 0.7f * Time.deltaTime;
        transform.localScale = Vector3.Lerp( Vector3.one,new Vector3(2, 2, 2), scaleValue);
    }

    private void ActiveCoins(int _amount)
    {
        foreach (var VARIABLE in coins)
        {
            VARIABLE.SetActive(false);
        }

        for (int i = 0; i < _amount; i++)
        {
            coins[i].SetActive(true);
        }
    }
    
    public void OnClickBtn(int _numberBtn)
    {
        isScale = true;
        Game.btnNumber = _numberBtn;
        game.DisableBtns();
    }
}
