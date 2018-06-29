using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour {

    bool isTriggered;
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LeftHand" || other.tag == "RightHand")
        {
            Debug.Log("trigger!!!!!!");
            anim.SetBool("hasEntered", true);
        }
    }
}
