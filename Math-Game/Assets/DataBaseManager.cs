
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;
using System.Collections;
using System;
using TMPro;

public class DataBaseManager : MonoBehaviour
{
    public  TMP_Text TMPScoreText;
    private int initScore = 200;
    private DatabaseReference dbReference;
    private string _userID;
    private Score _currentScore;
    // Start is called before the first frame update
    void Start()
    {
        _userID = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;

        Score score = new Score(initScore);
        _currentScore = score;
    }

    public void SaveScore()
    {
        string json = JsonUtility.ToJson(_currentScore);
        dbReference.Child("score").Child(_userID).SetRawJsonValueAsync(json);
    }
    public void AddToScore()
    {
        _currentScore.Add(100);
        SaveScore();
    }

    public IEnumerator GetScore(Action<string> onCallback)
    {
        var userScoreDate = dbReference.Child("score").Child(_userID).Child("_score").GetValueAsync();
        yield return new WaitUntil(predicate: () => userScoreDate.IsCompleted);
        if(userScoreDate != null)
        {
            DataSnapshot snapshot = userScoreDate.Result;
            onCallback.Invoke((snapshot.Value.ToString()));
        }   
    }

    public void GetUserScore()
    {
        StartCoroutine(GetScore((string score) => 
        {
            TMPScoreText.text = score;
        }));
    }
}
