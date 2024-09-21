

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_ItemChecker : MonoBehaviour
{
    private SCR_CreateRooms roomScr;
    string objectT;
    string objectToCheckName;
    GameObject objectToCheck;
  [SerializeField] private GameObject[] fadedObjs;
   [SerializeField] private Canvas itemcheckCanvas;
    [SerializeField] private Image[] checkerMats;
    public GameObject frameObj;

    GameObject currentDisplay;

    // Start is called before the first frame update
    void Start()
    {
        itemcheckCanvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void objectdesired(GameObject desiredobj, int number)
    {
        objectT = desiredobj.name;
        itemcheckCanvas.enabled = false;
        if (currentDisplay)
        {
            Destroy(currentDisplay);

        }
         currentDisplay = Instantiate(fadedObjs[number], this.gameObject.transform.position, this.gameObject.transform.rotation, this.gameObject.transform);
        currentDisplay.SetActive(true);
    }
    public void OnTriggerStay(Collider insertedObj)
    {
        objectToCheck = insertedObj.gameObject;
        objectToCheckName = objectToCheck.name;
        if (objectT == objectToCheckName)
        {
            itemcheckCanvas.enabled = true;
            checkerMats[0].enabled = true;
            checkerMats[1].enabled = false;

       //     itemcheckCanvas.enabled = true;
         //   itemText.enabled = true;
         //   itemText.text = "WOOOO";

            currentDisplay.SetActive(false);
            //yay
        }
        if (objectT != objectToCheckName)
        {
            //    itemcheckCanvas.enabled = true;
            //     itemText.enabled = true;
            //   itemText.text = "WOOOO";
            //boo
            itemcheckCanvas.enabled = true;
            checkerMats[0].enabled = false;
            checkerMats[1].enabled = true;
        }
    }
    public void checkObj(GameObject insertedObj)
    {
       
    }

}
