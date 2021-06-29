using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour
{
    public Text message;
    public Text question;
    public Button[] buttons;

    public MassageScriptObject[] massageScriptObjects;
    public int messageIndex = 0;
    int currentMessage = 0;

    public Transform[] questionPoints;

    MassageScriptObject mso;

    public void LoadMessage()
    {
        mso = massageScriptObjects[messageIndex];

        if (currentMessage < mso.Messages.Length)
        {
            message.gameObject.SetActive(true);
            question.gameObject.SetActive(false);
            message.text = mso.Messages[currentMessage];
            currentMessage++;
        }
        else
        {
            message.gameObject.SetActive(false);
            question.gameObject.SetActive(true);
            question.text = mso.Question;

            SetAnswerText();
        }
    }

    void SetAnswerText()
    {
        // ���� Ȱ��ȭ ��Ȱ��ȭ �κ�
        for(int i = 0; i < buttons.Length; i++)
        {
            if (i >= mso.Examples.Length)
            {
                buttons[i].gameObject.SetActive(false);
            }
            else
            {
                buttons[i].gameObject.SetActive(true);
            }
        }

        // ���⿡ �� ����
        for (int i = 0; i < mso.Examples.Length; i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = mso.Examples[i];
            
            if (i == mso.Answer - 1)
            {
                buttons[i].GetComponent<CheckAnswer>().Answer = true;
                buttons[i].GetComponent<CheckAnswer>().Point = mso.Point;
            }
        }
    }

    public void MoveToNextQuestion()
    {
        Invoke("InitializeQuestionUI", 2f);
        Invoke("MoveDoctorPaming", 2f);
    }

    void MoveDoctorPaming()
    {
        messageIndex++;
        currentMessage = 0;

        if (messageIndex < questionPoints.Length)
        {
            GetComponent<NavMeshAgent>().SetDestination(questionPoints[messageIndex].position);
        }
        else
        {
            // ���� ���� �κ� ����
        }
    }

    void InitializeQuestionUI()
    {
        GetComponent<DetactPlayer>().messageCanvas.SetActive(false);
    }
}
