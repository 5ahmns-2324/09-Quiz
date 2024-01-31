using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScript : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public QuizAnswers quizAnswers;

    void Update()
    {
        countText.text = "Count: " + quizAnswers.count.ToString();
    }

    public void RestartQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }
}
