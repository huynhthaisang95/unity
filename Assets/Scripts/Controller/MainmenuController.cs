using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuController : MonoBehaviour {

    public void _PlayIsland1() {
        SceneManager.LoadScene("Island1");
    }

    public void _PlayIsland2()
    {
        SceneManager.LoadScene("Island2");
    }
    public void _Quit() {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
