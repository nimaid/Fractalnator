using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInCenterOfView : MonoBehaviour
{
    public Camera targetCamera;
    public GameObject targetObjectParent;
    public GameObject targetObject;
    public float distance;
    public bool allowRotation = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // set position of parent
        targetObjectParent.transform.position = targetCamera.transform.position + targetCamera.transform.forward * distance;

        // set rotation of parent
        targetObjectParent.transform.rotation = targetCamera.transform.rotation;

        // counter-rotate screen if rotation is allowed
        if (allowRotation) {
            //TODO: This almost works, but "snaps" at certain points
            targetObject.transform.localEulerAngles = new Vector3(0, 0, (targetCamera.transform.rotation.z + 1) * 180);
        } else
        {
            targetObject.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
