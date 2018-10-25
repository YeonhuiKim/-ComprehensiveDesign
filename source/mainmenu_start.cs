using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu_start : MonoBehaviour {

	public void Change_Scene()
    {
        SceneManager.LoadScene("SceneOne");
    }
	
}
