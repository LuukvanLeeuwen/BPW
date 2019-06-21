using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePlayer : MonoBehaviour {

    public int playerHealth=50;
    int dmage=10;

	// Use this for initialization
	void Start ()
    {
        print(playerHealth);
		
	}

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag=="Enemy")
        {
            playerHealth -= dmage;
        
            print("Enemy hit you" + playerHealth);
        }
        if (playerHealth == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
