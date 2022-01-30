using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Enter Cinematics");
    }

    public void QuittGame()
    {
        Application.Quit();
    }

    public void DisplayCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
