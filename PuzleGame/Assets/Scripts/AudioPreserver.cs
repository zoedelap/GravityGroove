using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPreserver : MonoBehaviour
{
    private GameObject[] music;
 
 	void Start(){
 		music = GameObject.FindGameObjectsWithTag("gameMusic");
 		Destroy(music[1]);
 	}
 	
 	// Update is called once per frame
 	void Awake () {
 		DontDestroyOnLoad(transform.gameObject);
 	}
}
