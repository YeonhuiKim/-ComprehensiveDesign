using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour {

	private bool loadScene = false;
	public string LoadingSceneName;
	public Text loadingText;
	public Slider sliderBar;

	// Use this for initialization
	void Start () {
		sliderBar.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyUp (KeyCode.Space) && loadScene == false) {->스페이스바 눌렀을 경우
		if (loadScene == false) {
			loadScene = true;
			sliderBar.gameObject.SetActive (true);
			//loadingText.text = "Loading...";
			StartCoroutine(LoadNewScene(LoadingSceneName));
		}
	}
	IEnumerator LoadNewScene(string sceneName){
		AsyncOperation async = SceneManager.LoadSceneAsync (sceneName);

		while (!async.isDone) {
			float progress = Mathf.Clamp01 (async.progress / 0.9f);
			sliderBar.value = progress;
			loadingText.text = progress * 100f + "%";
			yield return null;
		}
	}
}
