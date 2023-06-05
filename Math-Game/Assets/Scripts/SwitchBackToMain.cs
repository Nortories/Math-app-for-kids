using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchBackToMain : MonoBehaviour
{
    [SerializeField] float delay = 5;
private IEnumerator Start()
    {
        yield return new WaitForSeconds(delay); // Delay for 5 seconds

        SceneManager.LoadScene(0); // Switch to the target scene
    }

}
