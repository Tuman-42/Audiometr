using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void StartPress()
    {
        SceneManager.LoadScene("Test1");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
