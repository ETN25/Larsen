using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Enter()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GhostPedia()
    {
        SceneManager.LoadScene("GhostPedia");
    }

    public void Leave()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

}
