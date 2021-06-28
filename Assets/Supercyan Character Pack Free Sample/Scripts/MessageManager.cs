using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{
    public Text message;
    public MassageScriptObject[] massageScriptObjects;
    public int messageIndex = 0;
    int currentMessage = 0;

    public void LoadMessage()
    {
        message.text = massageScriptObjects[messageIndex].Messages[currentMessage];
        if (currentMessage < massageScriptObjects[messageIndex].Messages.Length)
        {
            currentMessage++;
        }
    }
}
