using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    float spawnRange = 25f;
    public int enemyCount;
    public int waveNumber = 1;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public GameObject titleScreen;
    public GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Code used to spawn the enemies
    void Update()
    {
        //Finds the amount of enemies in the scene 
        enemyCount = FindObjectsOfType<Destroyer>().Length;

        //Code can only run when there are no enemies in the scene and isGameActive = true
        if (enemyCount == 0 && isGameActive)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }
    
    //Used to randomly spawn in the logs inside the boundaries provided 
    private Vector3 GenerateSpawnPosition()
    {
        float SpawnposX = Random.Range(-spawnRange, spawnRange);

        float SpawnposZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(SpawnposX, 10, SpawnposZ);

        return randomPos;
    }

    //Code used the calcuate how many enemies to spawn and Instantiates them
    void SpawnEnemyWave(int enemiesToSpawn)
    {

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    //Code used to keep track of the score 
    public void UpdateScore(int scoreToAdd)
    {
        
        //Makes the score go up in the UI
        scoreText.text = "Score: " + score;
        score += scoreToAdd;
    }

    //When Start button is clicked, this method is runned 
    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        SpawnEnemyWave(waveNumber);
        isGameActive = true;
    }

    //When a log hits the player controller, this method is runned 
    public void GameOver()
    {
        endScreen.gameObject.SetActive(true);
        isGameActive = false;
    }

    //When restart button is clicked, this method is runned 
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

    

