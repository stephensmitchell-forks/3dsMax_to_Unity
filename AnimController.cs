using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {
	Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			animator.SetInteger("state", 1);
		}else if(Input.GetKey("s")){
			animator.SetInteger("state", 0);
		}
	}
}
