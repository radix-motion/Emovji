using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VibrateOnTriggerEnter : MonoBehaviour
{
    float s;
    public bool isRightHand;
    // Start is called before the first frame update
    void Start()
    {
        s = 0;
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(isRightHand)
        {
            HapticAbstraction.BuzzNode(5f, UnityEngine.XR.XRNode.RightHand);
           // StartCoroutine(PlayFor());
        } else
        {
            HapticAbstraction.BuzzNode(5f, UnityEngine.XR.XRNode.LeftHand);
        }
        Debug.Log("buzzing");
    }

    IEnumerator PlayFor()
    {
        s += 0.02f;
        
        if (s < 1)
        {
            HapticAbstraction.BuzzNode(1000f, UnityEngine.XR.XRNode.RightHand);
            
        }
        
        yield return new WaitForSeconds(0.1f);

    }
    private void OnTriggerExit(Collider other)
    { 
        if (isRightHand)
        {
           // HapticAbstraction.BuzzNode(0f, UnityEngine.XR.XRNode.RightHand);
        }
        else
        {
           // HapticAbstraction.BuzzNode(0f, UnityEngine.XR.XRNode.LeftHand);
        }
        Debug.Log("not buzzing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
