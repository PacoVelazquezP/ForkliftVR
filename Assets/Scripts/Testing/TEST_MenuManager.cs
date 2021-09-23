﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TEST_MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _menuPanels;



    public void GoToPanel(int _panelID)
    {
        for(int i = 0; i< _menuPanels.Length; i++)
        {
            if(i == _panelID)
            {
                _menuPanels[i].SetActive(true);
            }else{
                _menuPanels[i].SetActive(false);
            }
        }
    }

    public void GoToScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}