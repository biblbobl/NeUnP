using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public int Cena;


	void OnTriggerEnter2D(Collider2D col) { 
		// money_player.money += Cena; 
		static_s.carrot += Cena;
		static_s.kost();
		Debug.Log (static_s.carrot.ToString());
		Debug.Log (static_s.max_carrot.ToString());
		GameObject.FindGameObjectWithTag ("Player").GetComponent<money_player> ().TextMoney.text = static_s.carrot.ToString() + " / " + static_s.max_carrot.ToString(); 
		Destroy (gameObject); 
		}
}

