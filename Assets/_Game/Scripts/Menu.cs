using System.Collections;
using System.Collections.Generic;
using Doozy.Engine;
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
        btQuit.OnClick.OnTrigger.Event.AddListener(OnClickButtonQuit);
    }

    // private void Update()
    // {
    // }
    #endregion


    private void OnClickButtonQuit()
    {
        GameEventMessage.SendEvent("StartGame");
        Application.Quit();
    }

}
