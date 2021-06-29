using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public bool Answer = false;
    public int Point;

    public void OnAnswerButtonClick()
    {
        if (Answer)
        {
            GetComponent<Image>().color = Color.blue;
            GameManager.Instance.Point += Point;
        }
        else
        {
            GetComponent<Image>().color = Color.red;
        }
    }
}
