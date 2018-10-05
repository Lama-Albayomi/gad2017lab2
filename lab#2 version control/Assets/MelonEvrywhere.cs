using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonEvrywhere : MonoBehaviour {

    public GameObject Karpuz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Karpuz,new Vector2 (Random.Range(-5f,5f),Random.Range(-10f,10f)), Quaternion.identity);
        }
	}
}
