using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void SetBoolOff()
    {
        anim.SetBool("hasEntered", false);
    }
}
