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
    void Update()
    {
        enemyCount = FindObjectsOfType<Destroyer>().Length;

        if (enemyCount == 0 && isGameActive)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float SpawnposX = Random.Range(-spawnRange, spawnRange);

        float SpawnposZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(SpawnposX, 10, SpawnposZ);

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {

        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        
        //Makes the score go up
        scoreText.text = "Score: " + score;
        score += scoreToAdd;
    }

    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        SpawnEnemyWave(waveNumber);
        isGameActive = true;
    }

    public void GameOver()
    {
        endScreen.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

    

