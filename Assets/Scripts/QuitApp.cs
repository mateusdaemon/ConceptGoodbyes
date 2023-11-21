using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void ExitApplication()
    {
        EditorApplication.ExitPlaymode();
        //Application.Quit();
    }
}
