using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money_player : MonoBehaviour
{
    static public int money;
	// public GameObject door;

	[SerializeField]
	public Text TextMoney; 


	void Start(){
		money = 0;
		static_s.door = GameObject.FindGameObjectWithTag("door");
		
	}

	void Update()
    {
        //if (money >=2) 
			//{ 
        //    Debug.Log ("123");
			//GameObject.FindGameObjectWithTag("door").SetActive(false);
			// door = Instantiate (door, door.transform.position, Quaternion.identity);
            // Debug.Log ("789");
            //}
    }
}