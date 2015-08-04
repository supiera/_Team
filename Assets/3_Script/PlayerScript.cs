﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float _speed = 5.0f;
	//public void Awake(){
	//	Animation ["1_damage"].speed = 2;
	//}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int _hp=100;
	public Animator _anim;
	public UISprite _GuageBarWidget;
	void OnTriggerEnter(Collider other)
	{
		_hp--;
		_anim.SetBool("damageChk", true);
		_GuageBarWidget.fillAmount = _hp * 0.01f;

	}
	void DamageEnd()
	{
		_anim.SetBool ("damageChk", false);

	}
}