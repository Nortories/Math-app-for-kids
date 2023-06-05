using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private float countdownDuration = 60f; // Duration of the countdown in seconds
    [SerializeField] private TMP_Text timerText; // Drag and drop the TMP text object here
    [SerializeField] private Slider slider;
    private float currentTime;

    private void Start()
    {
        currentTime = countdownDuration;
        slider.maxValue = countdownDuration;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            SceneManager.LoadScene(2); // scene index you want to load
        }
        slider.value = Mathf.FloorToInt(currentTime % 60f);
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timerString;
    }
}