using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetScore : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    void Start()
    {
        GameObject obj = GameObject.FindWithTag("score");
        if (obj != null)
        {
            // Use the GameObject reference as needed
            Debug.Log("Found GameObject with tag 'MyTag': " + obj.name);
            text.text = obj.name;
        }
        else
        {
            Debug.Log("No GameObject found with tag 'MyTag'");
        }
    }
}
