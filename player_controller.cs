using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player_controller : MonoBehaviour {
    public Rigidbody Character;
    public Animator anim;
    
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {

            float force = -1000 * Time.deltaTime;
            Character.AddForce(force, 0, 0);
            anim.SetBool("Left_walk", true);
            anim.SetBool("Right_walk", false);
            anim.SetBool("idle_left", false);

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Left_walk", false);
            anim.SetBool("Right_walk", false);
            anim.SetBool("idle_left", true);
        }
        
        
        if (Input.GetKey(KeyCode.D))
        {
            
            float force = 1000 * Time.deltaTime;
            Character.AddForce(force, 0, 0);
            anim.SetBool("Left_walk", false);
            anim.SetBool("Right_walk", true);
            anim.SetBool("idle_left", false);

        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Left_walk", false);
            anim.SetBool("Right_walk", false);
            anim.SetBool("idle_left", false);
        }
    


    }
 
  
}
