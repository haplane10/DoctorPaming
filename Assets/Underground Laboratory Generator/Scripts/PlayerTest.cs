using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveValue = Input.GetAxisRaw("Vertical");
        Debug.Log(moveValue);

        animator.SetInteger("Animation", (int)moveValue);
    }
}
