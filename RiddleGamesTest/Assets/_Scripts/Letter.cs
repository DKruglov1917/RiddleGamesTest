using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    public Animator animator;
    public static bool forcedOpen, forcedClose;

    private void Start()
    {
        forcedOpen = false;
        forcedClose = false;
    }

    public void SetOpenBool()
    {
        forcedOpen = true;
    }
    public void ResetOpenBool()
    {
        forcedOpen = false;
        animator.SetBool("open", true);
        animator.SetBool("opening", false);
        animator.SetFloat("openingSpeed", 1);

        Debug.Log("Opened!");
    }

    public void SetCloseBool()
    {
        forcedClose = true;
    }
    public void ResetCloseBool()
    {
        forcedClose = false;
        animator.SetBool("open", false);
        animator.SetBool("closing", false);
        animator.SetFloat("closingSpeed", 1);

        Debug.Log("Closed!");
    }

    private void Update()
    {
        ManageOpening();
        ManageClosing();
    }  

    private void ManageOpening()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("opening", true);
            animator.SetFloat("openingSpeed", 1);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && !forcedOpen)
        {
            animator.SetBool("opening", false);
            animator.SetFloat("openingSpeed", -1);
        }
    }

    private void ManageClosing()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetBool("closing", true);
            animator.SetFloat("closingSpeed", 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) && !forcedClose)
        {
            animator.SetBool("closing", false);
            animator.SetFloat("closingSpeed", -1);
        }
    }

}
