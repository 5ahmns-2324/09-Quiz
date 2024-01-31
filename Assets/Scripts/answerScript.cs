using UnityEngine;

public class answerScript : MonoBehaviour
{
    public GameManager gm;
    public bool isTrue;

    public void Clicked()
    {
        if (isTrue == true)
        {
            gm.counter++;
        }
    }
}
