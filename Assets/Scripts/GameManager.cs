using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public QuizAnswers quizAnswers;

    public GameObject[] answeres;
    public TextMeshProUGUI fragenText;
    public string fragenTextAnweisung;
    public string[] fragenTextAnweisungenListe;

    public int counter;
    public TextMeshProUGUI counterText;

    public int fragenCount;
    public TextMeshProUGUI fragenCountText;

    public GameObject nextButtonGO;

    public Image fragenButtonImage1;
    public Image fragenButtonImage2;
    public Image fragenButtonImage3;

    public Button fragenButton1;
    public Button fragenButton2;
    public Button fragenButton3;

    public TextMeshProUGUI timerText;
    public float timer = 10;
    public bool timerRunning = true;

    public int maxFragen = 5 + 1;


    public TextMeshProUGUI antwort1Text;
    public TextMeshProUGUI antwort2Text;
    public TextMeshProUGUI antwort3Text;

    public bool antwort1True = false;
    public bool antwort2True = false;
    public bool antwort3True = false;

    public Image questionImage;
    public Sprite[] questionImages;

    public bool randomizedAntwortenBool;


    public int fragenCountFF;


    // Start is called before the first frame update
    void Start()
    {
        fragenCount = 1;
        nextButtonGO.SetActive(false);

        Shuffle(answeres);
    }

    // Update is called once per frame
    void Update()
    {
        if (fragenCountFF == 5)
        {
            SceneManager.LoadScene("End");
        }

        quizAnswers.count = counter;
        counterText.text = counter + " / 5 Richtig";

        if (timerRunning)
        {
            timer -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timer).ToString();

            if (timer <= 0f)
            {
                AnswerClicked();
            }
        }

        fragenText.text = fragenTextAnweisung;

        if (fragenCount == 1)
        {
            fragenTextAnweisung = fragenTextAnweisungenListe[0];
            fragenCountText.text = "Frage 1 / 5";

            antwort1Text.text = "2024";
            antwort2Text.text = "2022";
            antwort3Text.text = "2023";

            /*  fragenButtonImage1.color = Color.white;
              fragenButtonImage2.color = Color.white;
              fragenButtonImage3.color = Color.white; */
        }

        if (fragenCount == 2)
        {
            fragenTextAnweisung = fragenTextAnweisungenListe[1];
            fragenCountText.text = "Frage 2 / 5";

            antwort1Text.text = "Rollerball";
            antwort2Text.text = "Jumpingball";
            antwort3Text.text = "Runningball";

            /*  fragenButtonImage1.color = Color.white;
              fragenButtonImage2.color = Color.white;
              fragenButtonImage3.color = Color.white; */
        }

        if (fragenCount == 3)
        {
            fragenTextAnweisung = fragenTextAnweisungenListe[2];
            fragenCountText.text = "Frage 3 / 5";

            antwort1Text.text = "HTBLuVA";
            antwort2Text.text = "HTBLuvA";
            antwort3Text.text = "HTLBuVA";

            /*  fragenButtonImage1.color = Color.white;
                        fragenButtonImage2.color = Color.white;
                        fragenButtonImage3.color = Color.white; */
        }

        if (fragenCount == 4)
        {
            fragenTextAnweisung = fragenTextAnweisungenListe[3];
            fragenCountText.text = "Frage 4 / 5";

            antwort1Text.text = "Mittwoch";
            antwort2Text.text = "Donnerstag";
            antwort3Text.text = "Montag";

            /*  fragenButtonImage1.color = Color.white;
                        fragenButtonImage2.color = Color.white;
                        fragenButtonImage3.color = Color.white; */
        }

        if (fragenCount == 5)
        {
            fragenTextAnweisung = fragenTextAnweisungenListe[4];
            fragenCountText.text = "Frage 5 / 5";

            antwort1Text.text = "Scriptable Object";
            antwort2Text.text = "PlayerPrefs";
            antwort3Text.text = "if-Schleife";

            /*  fragenButtonImage1.color = Color.white;
                        fragenButtonImage2.color = Color.white;
                        fragenButtonImage3.color = Color.white; */
        }

        /* if (fragenCount == maxFragen)
        {
            fragenCount = 1;
        } */ // Nur aktivieren wenn man es loopen will

    }

    public void NextQuestion()
    {
        Shuffle(answeres);


        fragenCountFF++;
        fragenCount++;
        nextButtonGO.SetActive(false);

        timer = 10;
        timerRunning = true;

        fragenButtonImage1.color = Color.white;
        fragenButtonImage2.color = Color.white;
        fragenButtonImage3.color = Color.white;

        fragenButton1.interactable = true;
        fragenButton2.interactable = true;
        fragenButton3.interactable = true;

        if (fragenCount < questionImages.Length)
        {
            questionImage.sprite = questionImages[fragenCount];
        }
    }

    public void AnswerClicked()
    {
        fragenButton1.interactable = false;
        fragenButton2.interactable = false;
        fragenButton3.interactable = false;

        timerRunning = false;

        nextButtonGO.SetActive(true);

        if (fragenCount == 1)
        {
            fragenButtonImage1.color = Color.green;
            fragenButtonImage2.color = Color.red;
            fragenButtonImage3.color = Color.red;
            Debug.Log("1 Answer Pressed");
        }

        if (fragenCount == 2)
        {
            fragenButtonImage1.color = Color.green;
            fragenButtonImage2.color = Color.red;
            fragenButtonImage3.color = Color.red;
        }

        if (fragenCount == 3)
        {
            fragenButtonImage1.color = Color.green;
            fragenButtonImage2.color = Color.red;
            fragenButtonImage3.color = Color.red;
        }

        if (fragenCount == 4)
        {
            fragenButtonImage1.color = Color.green;
            fragenButtonImage2.color = Color.red;
            fragenButtonImage3.color = Color.red;
        }

        if (fragenCount == 5)
        {
            fragenButtonImage1.color = Color.green;
            fragenButtonImage2.color = Color.red;
            fragenButtonImage3.color = Color.red;
        }
    }

    public void Shuffle(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            int destIndex = Random.Range(0, gameObjects.Length);
            GameObject source = gameObjects[i];
            GameObject dest = gameObjects[destIndex];
            if (source != dest)
            {
                Vector3 tmp = source.transform.position;
                source.transform.position = dest.transform.position;
                dest.transform.position = tmp;
            }
        }
    }
}
