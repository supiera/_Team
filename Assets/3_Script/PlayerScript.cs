using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float _speed = 5.0f;
	public UISprite _FeverBarWidget;
	//public void Awake(){
	//	Animation ["1_damage"].speed = 2;
	//}
	// Use this for initialization
	void Start () {
		_FeverBarWidget.fillAmount = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		_FeverBarWidget.fillAmount = 0.5f;
	}

	public int _hp=100;
	public Animator _anim;
	public UISprite _GuageBarWidget;
	void OnTriggerEnter(Collider other)
	{
		_hp--;
		_anim.SetBool("damageChk", true);
		_anim.SetBool ("damageAny", true);
		_GuageBarWidget.fillAmount = _hp * 0.01f;

	}
	void DamageEnd()
	{
		_anim.SetBool ("damageChk", false);

	}
}
