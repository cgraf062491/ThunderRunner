using UnityEngine;
using System.Collections;

public class SoldierController : MonoBehaviour {

	public float maxSpeed = 10f;

	bool facingRight = true;

	public float jumpTime = 2.5f;

	Animator anime;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	 Vector2 jumpVector = new Vector2(0,50);

	/*public float jumpForce1 = 700f;
	public float jumpForce2 = 500f;
	public float jumpForce3 = 400f;
	public float jumpForce4 = 300f;
	public float jumpForce5 = 200f;
	public float jumpForce6 = 100f;
	public float jumpForce7 = 700f;
	public float jumpForce8 = 500f;
	public float jumpForce9 = 400f;
	public float jumpForce10 = 300f;
	public float jumpForce11 = 200f;
	public float jumpForce12 = 100f;
	public float jumpForce13 = 700f;
	public float jumpForce14 = 500f;
	public float jumpForce15 = 400f;
	public float jumpForce16 = 300f;
	public float jumpForce17 = 200f;
	public float jumpForce18 = 100f;
	public float jumpForce19 = 200f;
	public float jumpForce20 = 100f;*/



	

	


	// Use this for initialization
	void Start () {

		anime = GetComponent<Animator>();

		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

		anime.SetBool("Ground", grounded);

		//secondsLeft = 0.3f;

		anime.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		float move = Input.GetAxis("Horizontal");

		anime.SetFloat("Speed", Mathf.Abs(1));

		GetComponent<Rigidbody2D>().velocity = new Vector2(1 * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		/*if(move > 0 && !facingRight){
			Flip();
		}else if(move < 0 && facingRight){
			Flip();
		}


		Physics2D.IgnoreLayerCollision(10, 11, GetComponent<Rigidbody2D>().velocity.y > 0);*/
	}

	void Update(){

		if(grounded && Input.GetKeyDown(KeyCode.Space)){
			anime.SetBool("Ground", false);

			//grounded = false;

			StartCoroutine(Jump());

			
			//rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}
			
	}

	IEnumerator Jump(){

		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().velocity = jumpVector;
		float timer = 0.0f;

		while(Input.GetKey(KeyCode.Space) && (timer < jumpTime)){

			float percentage = timer / jumpTime;
			Vector2 thisFrameJump = Vector2.Lerp(jumpVector, Vector2.zero, percentage);
			GetComponent<Rigidbody2D>().AddForce(thisFrameJump);
			timer += Time.deltaTime;
			yield return null;
		}

		//grounded = true;

	}

				/*GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce1));
				yield return new WaitForSeconds(0.05f);
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce2));
				yield return new WaitForSeconds(0.05f);
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce2));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce3));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce4));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce5));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce6));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce7));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce8));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce9));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce10));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce11));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce12));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce13));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce14));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce15));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce16));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce17));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce18));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce19));
				yield return 0;
				if(Input.GetKey(KeyCode.Space) && !grounded) GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce20));*/
				



		

	

	/*void Flip(){

		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}*/
}
