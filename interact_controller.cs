using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class interact_controller : MonoBehaviour {
    public GameObject textbx;
    public bool bigkeyleft = false;
    public bool bigkeyright = false;
    public bool key1 = false;
    // Use this for initialization
    void Start () {
        textbx.SetActive(false);
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Door1" && key1 == true)
        {
            SceneManager.LoadScene("level2");
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Door1" && key1 == false)
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "It's locked.";
      
            
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Big_door" && bigkeyleft == false && bigkeyright == false)
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "I think I see something staring at me.";
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Big_door" && bigkeyleft == true && bigkeyright == false)
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "I only got half.";
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Big_door" && bigkeyleft == false && bigkeyright == true)
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "I only got half.";
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Big_door" && bigkeyleft == true && bigkeyright == true)
        {
            textbx.SetActive(true);
            
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "key_trash" && key1 == false)
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "Oh look there is a key in here.";
            key1 = true;
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "key_trash" && key1 == true)
        {
            textbx.SetActive(true);
          
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "trash" )
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "Empty.";
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Door2")
        {
            SceneManager.LoadScene("level1");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_hall")
        {
            SceneManager.LoadScene("level2_hall");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_closet")
        {
            SceneManager.LoadScene("level2_closet");
        }
        else if (Input.GetKey(KeyCode.E)  && other.gameObject.tag == "door_main")
        {
            SceneManager.LoadScene("level2");
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_broken")
        {
            textbx.SetActive(true);
            textbx.GetComponent<UnityEngine.UI.Text>().text = "The door is broken.";
        }
        else if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_pet")
        {

        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_kitchen")
        {
            SceneManager.LoadScene("level2_kitchen");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_photo")
        {
            SceneManager.LoadScene("level2_photo");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_pantry")
        {
            SceneManager.LoadScene("level2_pantry");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_lab")
        {
            SceneManager.LoadScene("level2_lab");
        }
        else if(Input.GetKey(KeyCode.E) && other.gameObject.tag == "door_dining")
        {
            SceneManager.LoadScene("level2_dining");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        textbx.GetComponent<UnityEngine.UI.Text>().text = "";
        
    }
}
