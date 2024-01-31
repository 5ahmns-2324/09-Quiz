using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntwortSkript : MonoBehaviour
{
    string antwortText;
    bool valid;

    public AntwortSkript() { }

    public void SetAntwortText(string antwortText)
    {
        this.antwortText = antwortText;
    }

    public string GetAntwortText()
    {
        return antwortText;
    }

    public bool IsValid()
    {
        return valid;
    }

    public void SetValid(bool valid)
    {
        this.valid = valid;
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
