using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(TitleScreen);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TitleScreen()
    {
        titleScreen.gameObject.SetActive(false);
    }
}
