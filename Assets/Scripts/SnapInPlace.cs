using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class SnapInPlace : MonoBehaviour
{
    public GameObject desiredObject;
    Vector3 objectPosition;
    Vector3 objectSize;

    // Start is called before the first frame update
    void Start()
    {
        objectPosition = gameObject.GetComponent<BoxCollider>().center;
        objectSize = gameObject.GetComponent<BoxCollider>().size;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MyCollisions();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == desiredObject.name)
        {
            // if it is, copy the position and rotation of this object over to the desiredObject
            // disable all the grabbing scripts within the object as well (make it dumb)
            desiredObject.transform.position = gameObject.transform.position;
            desiredObject.transform.rotation = gameObject.transform.rotation;
            desiredObject.GetComponent<ObjectManipulator>().enabled = false;
            desiredObject.GetComponent<NearInteractionGrabbable>().enabled = false;
        }

    //void MyCollisions()
    //{
    //    //Use the OverlapBox to detect if there are any other colliders within this box area.

    //    //Use the GameObject's centre, half the size (as a radius) and rotation. This creates an invisible box around your GameObject.

    //    //Use the Box Collider information:


    //    Collider[] hitColliders = Physics.OverlapBox(objectPosition, objectSize / 2, Quaternion.identity, 1 << 0);

    //    int i = 0;


    //    //Check when there is a new collider coming into contact with the box
    //    while (i < hitColliders.Length)
    //    {
    //        Debug.Log("hitColliders[i].name");
    //        Debug.Log("desiredObject.name");
    //        // if the collider detects an object in it's overlap box then check to see if it is the desired object
    //        if (hitColliders[i].name == desiredObject.name)
    //        {
    //            // if it is, copy the position and rotation of this object over to the desiredObject
    //            // disable all the grabbing scripts within the object as well (make it dumb)
    //            desiredObject.transform.position = gameObject.transform.position;
    //            desiredObject.transform.rotation = gameObject.transform.rotation;
    //            desiredObject.GetComponent<ObjectManipulator>().enabled = false;
    //            desiredObject.GetComponent<NearInteractionGrabbable>().enabled = false;
    //        }

    //    }
    }
}
