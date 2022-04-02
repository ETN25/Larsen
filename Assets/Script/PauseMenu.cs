using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool Pause;
    [SerializeField] GameObject Menu;
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
                Time.timeScale = 0;
                Menu.SetActive(true);
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Pause = false;
                Time.timeScale = 1;
                Menu.SetActive(false);
                
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
        Menu.SetActive(false);
    }
}
