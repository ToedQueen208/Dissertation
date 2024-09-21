
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_CreateRooms : MonoBehaviour
{
    public Transform[] wallpos1;
    public Transform[] wallpos2;
    public GameObject[] walls;
    public GameObject[] objects;
    public List<Transform> objectPlaces;

 [SerializeField] private SCR_ItemChecker itemcheckerSCR;

    public int randNumber;
    public int randobj;
    public bool pleaseWork;
    public bool pleaseWork2;
    public bool pleaseWork3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /* if (pleaseWork == true)
        {
            pleaseWork = false;
            pleaseWork2= false;
            pleaseWork3 = false;
            createRoom("small");
        }
        if (pleaseWork2 == true)
        {
            pleaseWork = false;
            pleaseWork2 = false;
            pleaseWork3 = false;
            createRoom("medium");
        }
        if (pleaseWork3 == true)
        {
            pleaseWork = false;
            pleaseWork2 = false;
            pleaseWork3 = false;
            createRoom("large");
        }*/
    }

    public void createRoom(string choice)
    {
       
          foreach (GameObject go in GameObject.FindGameObjectsWithTag("GrabObj"))
        {
            Destroy(go);
        }
        //code adapted from https://answers.unity.com/questions/1296696/collect-list-of-transforms-based-on-tag.html
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("PlaceSmall"))
        {
            objectPlaces.Add(go.transform);
        }
        //end of adapted code
        switch (choice)
        {
            case "small":
                
                //code adapted from https://answers.unity.com/questions/318607/how-to-access-the-size-of-a-list-c.html
                randNumber = Random.Range(0, objectPlaces.Count);
                //end of adapted code
                  randobj = Random.Range(0, objects.Length );
               
                walls[0].transform.position = wallpos1[0].position;
                walls[1].transform.position = wallpos2[0].position;

            GameObject obj = Instantiate(objects[randobj] , objectPlaces[randNumber].position, objectPlaces[randNumber].rotation, objectPlaces[randNumber]);
                objectPlaces.Clear();
                itemcheckerSCR.objectdesired(obj, randobj);
                break;

            case "medium":
       
                foreach (GameObject go in GameObject.FindGameObjectsWithTag("PlaceMedium"))
                {
                    objectPlaces.Add(go.transform);
                }
                          
                walls[0].transform.position = wallpos1[1].position;
                walls[1].transform.position = wallpos2[1].position;

            
                    randobj = Random.Range(0, objects.Length);
                    //code adapted from https://answers.unity.com/questions/318607/how-to-access-the-size-of-a-list-c.html
                    randNumber = Random.Range(0, objectPlaces.Count);
                //end of adapted code
                GameObject objM =  Instantiate(objects[randobj], objectPlaces[randNumber].position, objectPlaces[randNumber].rotation, objectPlaces[randNumber]);
                objectPlaces.Clear();
                itemcheckerSCR.objectdesired(objM, randobj);
                break;
            case "large":

                foreach (GameObject go in GameObject.FindGameObjectsWithTag("PlaceMedium"))
                {
                    objectPlaces.Add(go.transform);
                }
                foreach (GameObject go in GameObject.FindGameObjectsWithTag("PlaceLarge"))
                {
                    objectPlaces.Add(go.transform);
                }

                walls[0].transform.position = wallpos1[2].position;
                walls[1].transform.position = wallpos2[2].position;

             
                    randobj = Random.Range(0, objects.Length);
                    //code adapted from https://answers.unity.com/questions/318607/how-to-access-the-size-of-a-list-c.html
                    randNumber = Random.Range(1, objectPlaces.Count);
                //end of adapted code
                GameObject objL = Instantiate(objects[randobj], objectPlaces[randNumber].position, objectPlaces[randNumber].rotation, objectPlaces[randNumber]);
                objectPlaces.Clear();
                itemcheckerSCR.objectdesired(objL, randobj);
                objectPlaces.Clear();
                break;

            default:
                break;
        }

    }

}
