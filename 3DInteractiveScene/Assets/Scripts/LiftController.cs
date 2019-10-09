using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{

    public GameObject liftObject;

    private bool liftup;
    private bool buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        buttonPressed = true;
    }

    void OnMouseExit()
    {
        buttonPressed = false;
    }

    void OnMouseDown()
    {
        liftup = !liftup;
        liftObject.GetComponent<Animator>().SetBool("LiftIsUp", liftup);
    }

    void OnGUI()
    {
        if (buttonPressed == true)
        {
            GUI.Box(
                new Rect(
                    Screen.width / 2 - 200,
                    Screen.height / 2 - 25,
                    200,
                    50),
                "Press Button"
                );
        }
    }


}
