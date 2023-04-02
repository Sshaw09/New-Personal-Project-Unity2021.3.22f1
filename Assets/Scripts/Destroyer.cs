using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //Locates where the game manager object is and gets the game manager script 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //When it the log colldies with the ground, it gets destroyed
    private void OnTriggerEnter(Collider other)
    {
        //When the log collides with the player, it destroys the player and starts the GameOver method in the gameManager 
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            gameManager.GameOver();
        }

        //When logs hits the ground it destroys it's self and makes the score go up by 10 points 
        Destroy(gameObject);
        gameManager.UpdateScore(10);


    }




}
