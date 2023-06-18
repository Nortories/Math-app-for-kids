using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    GameObject scoreGameObj = GameObject.FindWithTag("score");

    void Start()
    {
        if (scoreGameObj != null)
        {
            // Use the GameObject reference as needed
            Debug.Log("Found GameObject with tag 'score': " + scoreGameObj.name);
            text.text = scoreGameObj.name;
        }
        else
        {
            Debug.Log("No GameObject found with tag 'score'");
        }
    }
}
