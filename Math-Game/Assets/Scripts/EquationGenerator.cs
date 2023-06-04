using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EquationGenerator : MonoBehaviour
{
    
    [SerializeField] private TMP_Text equationText; // Drag and drop the TMP text object here
    [SerializeField] private TMP_Text AnswerText;
    [SerializeField] private TMP_Text AnswerText1;
    [SerializeField] private TMP_Text AnswerText2;
    [SerializeField] private TMP_Text AnswerText3;
    [SerializeField] private TMP_Text AnswerText4;
    [SerializeField] private TMP_Text AnswerText5;
    [SerializeField] private int generationMin = 1;
    [SerializeField] private int generationMax = 100;
    [SerializeField] private float timeInterval = 1f; // Time interval between generating new equations
    [SerializeField] private GameObject GameObjectResult;
    private int _result;
    private Coroutine invokeCoroutine;
     private void Start()
    {
        StartRepeatedInvocation();
    }

    public void StartRepeatedInvocation()
    {
        if (invokeCoroutine != null)
        {
            StopCoroutine(invokeCoroutine);
        }

        invokeCoroutine = StartCoroutine(InvokeRepeatingCoroutine());
    }

    private IEnumerator InvokeRepeatingCoroutine()
    {
        while (true)
        {
            UpdateEquation();
            yield return new WaitForSeconds(timeInterval);
        }
    }

    public void UpdateEquation()
    {
        int num1 = RandomNumber();
        int num2 = RandomNumber();
        int result = num1 + num2;
        _result = result;
        GameObjectResult.name = _result.ToString();
        UpdateButtonText();

        string equation = string.Format("{0} + {1} = ?", num1, num2);
        equationText.text = equation;
    }
    public int GetMathAnswer(){
        return _result;
    }

    private int RandomNumber()
    {
        return Random.Range(generationMin, generationMax);
    }

    public void UpdateButtonText(){
        List<TMP_Text> answerButton = new List<TMP_Text>();
        answerButton.Add(AnswerText);
        answerButton.Add(AnswerText1);
        answerButton.Add(AnswerText2);
        answerButton.Add(AnswerText3);
        answerButton.Add(AnswerText4);
        answerButton.Add(AnswerText5);

        // Generate a random index to select one button for the _results variable
        int randomIndex = Random.Range(0, answerButton.Count);

        // Assign the _results variable to the randomly selected button
        answerButton[randomIndex].text = _result.ToString();

        // Generate random num for the remaining buttons
        for (int i = 0; i < answerButton.Count; i++)
        {
            if (i != randomIndex)
            {
                int randomNum = RandomNumber();
                answerButton[i].text = randomNum.ToString();
            }
        }
    }
}