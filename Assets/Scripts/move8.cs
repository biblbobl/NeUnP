using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move8 : MonoBehaviour
{
    public Rigidbody2D RigBud;
	public float movespeed;
	public float jumpheight;
	private bool moveright;
	private bool moveleft;
	private bool jump;
	private bool baloon;
	public Transform groundCheck;
	public float groundCheckRadius;
    private bool isGround;
	public LayerMask WoIG;
    private Animator anim;
    public float Horizontal;
    public float Vertical;
    private bool deth;
	public GameObject baloonSh; //Снаряд
	public Transform firePoint; //Точка, с которой будут отправляться снаряды и лучи

	// Use this for initialization
	void Start () {
		RigBud = GetComponent <Rigidbody2D> ();
        anim = GetComponent<Animator>();
	}
	void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, WoIG);
        anim.SetBool ("jump", isGround);
        if (!isGround)
        return;
	}
	// Update is called once per frame

	void Update () {

		

        if (deth == true) {
				  return;
		}

        Horizontal = Input.GetAxis("Horizontal");
        if (Horizontal == 0)
        {
            anim.SetBool ("run", false);
        }

        Vertical = Input.GetAxis("Vertical");
        if (Vertical == 0)
        {
            anim.SetBool ("jump", false);
        }

		if (Input.GetKey (KeyCode.LeftArrow)) {
			RigBud.velocity = new Vector2 (-movespeed, RigBud.velocity.y);
			transform.rotation = Quaternion.Euler (0, 180, 0);
            anim.SetBool ("run", true);
			
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			RigBud.velocity = new Vector2 (movespeed, RigBud.velocity.y);
			transform.rotation = Quaternion.Euler (0, 0, 0);
            anim.SetBool ("run", true);
			
		} 
		if (moveright) {
			RigBud.velocity = new Vector2 (movespeed, RigBud.velocity.y);
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		if (moveleft) {
			RigBud.velocity = new Vector2 (-movespeed, RigBud.velocity.y);
			transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		if (isGround && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)))
		{
		RigBud.velocity = new Vector2(RigBud.velocity.x, jumpheight);
		anim.SetBool("jump", jump = true);
		}
		if (isGround && jump) {
		RigBud.velocity = new Vector2 (RigBud.velocity.x, jumpheight);
		anim.SetBool ("jump", jump = false);
		}
		if (Input.GetKeyUp (KeyCode.F)) {
		StartCoroutine(Shoot());
		anim.Play("bunny_baloon");
		}
	}

IEnumerator Shoot(){
	yield return new WaitForSeconds(0.8f);
	Instantiate(baloonSh, firePoint.position, firePoint.rotation);
}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn") {
            anim.SetBool("deth", true);
			static_s.restart();
        }
    }
}