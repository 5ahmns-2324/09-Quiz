using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSkript : MonoBehaviour
{
    int score;
    FrageScript[] fragen;

    string frage1Text = "Frage 1";
    string frage2Text = "Frage 2";
    string frage3Text = "Frage 3";

    private FrageScript[] meineFragen;

    // Start is called before the first frame update
    void Start()
    {
        // testen
        AntwortSkript a1 = new AntwortSkript();
        a1.SetAntwortText("f1a1");
        AntwortSkript a2 = new AntwortSkript();
        a1.SetAntwortText("f1a2");
        AntwortSkript a3 = new AntwortSkript();
        a1.SetAntwortText("f1a3");

        AntwortSkript[] antwortenF1 = new AntwortSkript[3] {a1, a2, a3}; 

        FrageScript frage1 = new FrageScript();
        frage1.SetFragenText(frage1Text);

        FrageScript frage2 = new FrageScript();
        frage2.SetFragenText(frage2Text);

        FrageScript frage3 = new FrageScript();
        frage3.SetFragenText(frage3Text);

        frage1.SetAntworten(antwortenF1);
        frage1.PrintAllAntworten();

        AntwortSkript[] antwortenF2 = new AntwortSkript[3];
        frage2.SetFragenText(frage2Text);

        for (int i = 0; i < antwortenF2.Length; i++)
        {
            antwortenF2[i] = new AntwortSkript();
        }

        antwortenF2[0].SetAntwortText("f2a1");
        antwortenF2[1].SetAntwortText("f2a2");
        antwortenF2[2].SetAntwortText("f2a3");
        frage2.SetAntworten(antwortenF2);
        frage2.PrintAllAntworten();

        meineFragen = new FrageScript[3] { frage1, frage2, frage3 };
        
        for (int i = 0; i < 100; i++)
        {
            // Debug.Log(meineFragen[Random.Range(0, 3)].GetFragenText());
        }

        // durchlaufen
        foreach (FrageScript mf in meineFragen)
        {
            mf.GetFragenText();
            //Debug.Log("meineFragen[" + i + "] ist " + meineFragen[i].GetFragenText());
        }
        Debug.Log(meineFragen[Random.Range(0, 3)].GetFragenText());
        Debug.Log(meineFragen[Random.Range(0, 3)].GetFragenText());
        Debug.Log(meineFragen[Random.Range(0, 3)].GetFragenText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
