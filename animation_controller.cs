using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_controller : MonoBehaviour
{
    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("Left_walk", true);
            anim.SetBool("Right_walk", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("Left_walk", false);
            anim.SetBool("Right_walk", true);
        }
    }
}
