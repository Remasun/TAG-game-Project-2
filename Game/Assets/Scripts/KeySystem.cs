using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour {

    public int keys;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (keys >= 5)
        {
            GameWin();
        }
	}

    public void GameWin()
    {
        print("win!");
    }

    public void Key(GameObject u)
    {
        keys += 1;
        Destroy(u);
    }
}
