using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VibrateController : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {

        OVRInput.SetControllerVibration(1.0f, 0.5f, OVRInput.Controller.RTouch);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            OVRInput.SetControllerVibration(1.0f, 0.5f, OVRInput.Controller.RTouch);
            Debug.Log("vibrate");
        }
    }
}
