using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlinkiPassLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D trigger)
    {

        if (trigger.CompareTag("Ganar"))
        {
            SceneManager.LoadScene(3);
        }
        


    }
}
