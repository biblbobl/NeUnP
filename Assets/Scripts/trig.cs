using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trig : MonoBehaviour
{
   public string player; 

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == player) {  
			                     
			{
					if (SceneManager.GetActiveScene ().buildIndex == level.Levels) {  
						level.Levels++; 
					}
				static_s.restart();
				SceneManager.LoadScene (5);
			}
			}
		// УСЛОВИЯ ПРОИГРЫША!
		if (Input.GetKeyDown (KeyCode.P)) { 
			Debug.Log ("NO....");           
			SceneManager.LoadScene (5);
		}

	}
	}
