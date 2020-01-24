using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour
{
    private move8 player;
    public Transform start;
    public GameObject Explode;

    void Start()
    {
       player = FindObjectOfType<move8> ();
    }

    
    void Update()
    {
        
    }

    IEnumerator deadly()
    {
        yield return new WaitForSeconds(0.6f);
        //player.transform.position = start.position;
        Application.LoadLevel(Application.loadedLevel);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
		if (other .tag == "Player") 
        {

            StartCoroutine("deadly");
            }
		}
	}

