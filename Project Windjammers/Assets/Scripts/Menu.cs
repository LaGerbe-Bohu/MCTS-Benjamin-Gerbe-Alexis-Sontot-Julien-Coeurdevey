using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void beginGame()
    {
        InterfaceGameState.J1set = 0;
        InterfaceGameState.J2set = 0;
        

        SceneManager.LoadScene(1);
    }

    public void quitGame() {
        Application.Quit();
    }

    public void returnMenu() {
        SceneManager.LoadScene(0);
    }
}
