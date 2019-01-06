﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour {
	public Vector2 velocity;
	private bool walk, walk_left, walk_right, jump;
	void Start () {	
	}
	void Update () {
		CheckPlayerInput ();
		UpdatePlayerPosition ();
	}
	void UpdatePlayerPosition(){
		Vector3 pos = transform.localPosition;
		Vector3 scale = transform.localScale;


		if (walk) {
			if (walk_left) {
				pos.x -= velocity.x *Time.deltaTime;
				scale.x = -1;
			}
			if (walk_right) {
				pos.x += velocity.x *Time.deltaTime;
				scale.x = 1;

			}
		}
	}
	void CheckPlayerInput () {
		bool input_left = Input.GetKey(KeyCode.LeftArrow);
		bool input_right = Input.GetKey(KeyCode.RightArrow);
		bool input_space = Input.GetKey(KeyCode.Space);

		walk = input_left || input_right;
		walk_left = input_left && !input_right;
		walk_right = !input_left && input_right;
		jump = input_space;



	}
}
