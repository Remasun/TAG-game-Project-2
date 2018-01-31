using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour {

    public GameObject prefab;
    public float health = 1;
    public float dis;
    public GameObject player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        dis = Vector3.Distance(player.transform.position, transform.position);
        if (dis <= 100)
        {
            Instantiate(prefab, transform.position, gameObject.transform.rotation);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HealthDown (float damage)
    {
        health -= damage;
    }
}
