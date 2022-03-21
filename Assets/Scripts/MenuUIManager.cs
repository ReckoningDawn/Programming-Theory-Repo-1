using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    private void StartGame() // start button
    {
        SceneManager.LoadScene(1);
    }

    private void BackMenu() // back button
    {
        SceneManager.LoadScene(0);
    }

    private void Exit() // exit game
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
