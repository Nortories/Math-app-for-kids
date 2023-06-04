using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    private TMP_Text tmpText;

    private void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        gameObject.name = "0";
    }

    private void Update()
    {
        tmpText.text = gameObject.name;
    }
}