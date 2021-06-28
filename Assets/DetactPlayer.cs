using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetactPlayer : MonoBehaviour
{
    public GameObject messageCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Enter " + other.name);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                messageCanvas.SetActive(true);
                GetComponent<MessageManager>().LoadMessage();
            }
            Debug.Log("Stay " + other.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            messageCanvas.SetActive(false);
            Debug.Log("Exit " + other.name);
        }
    }
}
