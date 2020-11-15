using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemeneg : MonoBehaviour
{
    public void backPress()
    {
        SceneManager.LoadScene("Menu");
    }
}
