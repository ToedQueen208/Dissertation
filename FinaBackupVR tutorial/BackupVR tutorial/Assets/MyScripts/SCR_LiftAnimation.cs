using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SCR_LiftAnimation : MonoBehaviour
{
    [SerializeField] Animator dooranim;
 

    public bool startCount;

    public float counter;
    public float runTime;
    // Start is called before the first frame update
    void Start()
    {
        startCount = false;   
    }

    // Update is called once per frame
    void Update()
    {

        if (startCount == true)
        {
            counter += 1 * Time.deltaTime;

            if (counter >= runTime)
            {
                counter = 0;
                OpenDoors();
            }
        }
    }

    public void OpenDoors()
    {
        Debug.Log("wewoo");
        startCount = false;
        dooranim.SetBool("isPressed", true);
              
    }
    public void CloseDoors()
    {

        dooranim.SetBool("isPressed", false);

    }
    public void LiftButtonPressed(int seconds)
    {
        Debug.Log("yee");
        runTime = seconds;
        startCount = true;
        CloseDoors();
    }
  

   
}
