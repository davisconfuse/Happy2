using UnityEngine;
using System.Collections;
	
public class ControllerPlayer : MonoBehaviour {

	public float speed = 0.1F;

	Animator animator;


	void Start ()
	{
		animator = transform.GetComponentInChildren<Animator> ();
		}

	void Update() 
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
		}

		Movement ();
	}
		
		
	void Movement()
	{
	  
	
 	  if (Input.GetKey (KeyCode.D)) {
		transform.Translate (Vector2.right * 9f * Time.deltaTime);
		transform.eulerAngles = new Vector2 (0, 0);
			animator.SetTrigger("DoWalk");


          }
 	  if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.right * 9f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 180);
			animator.SetTrigger("DoWalk");

		
		}
	  if (Input.GetKeyDown (KeyCode.E)) {
			transform.Translate (Vector2.right * 0f * Time.deltaTime);
			if (Input.GetKey (KeyCode.D))
			transform.eulerAngles = new Vector2 (0, 0);
			if (Input.GetKey (KeyCode.A))
			transform.eulerAngles = new Vector2 (0, 180);

			animator.SetTrigger("DoAttack");

		}
	  if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.up * -9f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			if (Input.GetKey (KeyCode.A))
			transform.eulerAngles = new Vector2 (0, 180);
			animator.SetTrigger("DoWalk");
			
			
		}
	  if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * 9f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
			if (Input.GetKey (KeyCode.A))
			transform.eulerAngles = new Vector2 (0, 180);
			animator.SetTrigger("DoWalk");

		}

	  }
	void FixedUpdate () 
		{

	}
}