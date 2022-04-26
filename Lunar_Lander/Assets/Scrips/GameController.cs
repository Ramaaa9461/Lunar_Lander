using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void OnLoadLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void OnExit()
    {
        Application.Quit();
    }
}
