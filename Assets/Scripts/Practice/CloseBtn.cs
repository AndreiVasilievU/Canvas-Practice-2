using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtn : MonoBehaviour
{
    [SerializeField] private GameObject go;

    public void OnCloseBtn()
    {
        go.SetActive(false);
    }
}
