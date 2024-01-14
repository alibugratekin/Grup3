using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Input.ResetInputAxes();

    }
    public void PlayGame()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
        
    public void ReturnMenu()
    {
        Debug.Log("Menu!");
        SceneManager.LoadScene(0);
    }
}
