using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public  void AdditionScene()
    {
        DelayedFunction(0.5f);
        Debug.Log("additionScene");
        SceneManager.LoadScene(1);
    }

    IEnumerator DelayedFunction(float delay)
    {
        Debug.Log("Function called");

        yield return new WaitForSeconds(delay); // delay-second

        Debug.Log("Delayed code executed");
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }
}
