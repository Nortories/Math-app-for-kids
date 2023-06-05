using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private GameObject Answer;
    [SerializeField] private TMP_Text AnswerText;
    [SerializeField] private Button _button;
    [SerializeField] private GameObject MathQu;
    [SerializeField] private GameObject score;
    private ColorBlock originalColorBlock;

    public void CheckAnswers()
    {
        ColorBlock colorBlock = _button.colors;
        var defaltButtonColor = colorBlock;

        if (int.Parse(Answer.name) == int.Parse(AnswerText.text))
        {
            colorBlock.normalColor = Color.green;
            colorBlock.selectedColor = Color.green;
            Debug.Log("Correct");
            var equationGenerator = MathQu.GetComponent<EquationGenerator>();
            equationGenerator.StartRepeatedInvocation();
            score.name = (int.Parse(score.name) + 100).ToString();
            GameObject answerButtonsObject = GameObject.Find("answers");
            if (answerButtonsObject != null)
            {
                ButtonSounds otherScript = answerButtonsObject.GetComponent<ButtonSounds>();
                if (otherScript != null)
                {
                    // Access the methods or properties of the OtherScript component
                    otherScript.Sound1();
                }
            }
        }
        else
        {
            colorBlock.normalColor = Color.red;
            colorBlock.selectedColor = Color.red;
            Debug.Log("Wrong");
            score.name = (int.Parse(score.name) - 50).ToString();
            GameObject answerButtonsObject = GameObject.Find("answers");
            if (answerButtonsObject != null)
            {
                ButtonSounds otherScript = answerButtonsObject.GetComponent<ButtonSounds>();
                if (otherScript != null)
                {
                    // Access the methods or properties of the OtherScript component
                    otherScript.Sound2();
                }
            }

        }

        _button.colors = colorBlock;
        _button.image.SetAllDirty(); // Force immediate update of button appearance

        StartCoroutine(ResetButtonColor(defaltButtonColor));
    }

    private IEnumerator ResetButtonColor(ColorBlock defaltButtonColor)
    {
        // Wait for 0.5 seconds
        yield return new WaitForSeconds(0.5f);

        // Reset the button color to the original color block
        _button.colors = defaltButtonColor;
        _button.image.SetAllDirty(); // Force immediate update of button appearance
    }
}