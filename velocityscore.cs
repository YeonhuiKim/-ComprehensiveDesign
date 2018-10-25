using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class velocityscore : MonoBehaviour {

	public Text Text_velocity;

	public MSSceneController sceneCode;

	
	// Update is called once per frame

	void Update () {
		Text_velocity.text = sceneCode.velocitykmh;

	}
}
