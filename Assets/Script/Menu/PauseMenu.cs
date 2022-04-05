using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool Pause;
    [SerializeField] GameObject MainMenu, OptionMenu, GhostPediaMenu, ItemPediaMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Pause)
            {
                Pause = true;
                //Time.timeScale = 0;
                MainMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Pause = false;
                Time.timeScale = 1;
                MainMenu.SetActive(false);
                OptionMenu.SetActive(false);
                GhostPediaMenu.SetActive(false);
                ItemPediaMenu.SetActive(false);

            }

        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Resume()
    {
        Pause = false;
        Time.timeScale = 1;
        MainMenu.SetActive(false);
    }

    public void Option()
    {
        OptionMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void GhostPedia()
    {
        GhostPediaMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void ItemPedia()
    {
        ItemPediaMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Back()
    {
        MainMenu.SetActive(true);
        OptionMenu.SetActive(false);
        GhostPediaMenu.SetActive(false);
        ItemPediaMenu.SetActive(false);
    }
}
