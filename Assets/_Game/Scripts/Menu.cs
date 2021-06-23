using System.Collections;
using System.Collections.Generic;
using Doozy.Engine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{

    //
    //= inspector
    [SerializeField] private UIButton btPlay;
    [SerializeField] private UIButton btSetting;
    [SerializeField] private UIButton btQuit;


    #region UNITY
    private void Start()
    {
        
    }

    // private void Update()
    // {
    // }
    #endregion


    private void OnClickButtonQuit()
    {
        Application.Quit();
    }

}
