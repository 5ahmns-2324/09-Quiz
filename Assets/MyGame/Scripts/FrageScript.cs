using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrageScript
{
    [SerializeField] string fragenText;
    AntwortSkript[] antworten;

    public FrageScript()
    {
        Debug.Log("Erstelle Frage");
    }

    public void SetFragenText(string frageText)
    {
        fragenText = frageText;
        Debug.Log(fragenText);
    }

    public string GetFragenText()
    {
        return fragenText;
    }

    public void SetAntworten(AntwortSkript[] antworten)
    {
        this.antworten = antworten;
    }

    public void PrintAllAntworten()
    {
        foreach (AntwortSkript aw in antworten)
        {
            Debug.Log(aw.GetAntwortText());
        }
    }

    public void RandmizeAntworten()
    {
        int i = Random.Range(0, antworten.Length);
        int[] order = new int[3];
        
        // erstes Element im Array
        order[0] = i;
        i = Random.Range(0, antworten.Length);

        // zweites Element im Array
        while (order[0] == i)
        {
            i = Random.Range(0, antworten.Length);
        }
        
        order[1] = i;

        // drittes Element im Array
        i = Random.Range(0, antworten.Length);

        while (order[0] == i || order[1] == i)
        {
            i = Random.Range(0, antworten.Length);
        }

        order[2] = i;


        foreach (int index in order)
        {
            Debug.Log("order" + index);
        }



        AntwortSkript[] tmpAnt = new AntwortSkript[3];
        System.Array.Copy(antworten, tmpAnt, antworten.Length);


        for (int x = 0; i < antworten.Length; x++)
        {
            antworten[i] = tmpAnt[order[i]];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
