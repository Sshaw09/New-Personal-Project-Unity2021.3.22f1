using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    //THIS SCRIPT IS NOT IN USED ANYMORE
    //Previous use was for the start game button to make the start game method run
    //Now using the Component OnClick

    private Button button;
    private GameManager gameManager;
    public GameObject titleScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(gameManager.StartGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TitleScreen()
    {
        
    }
}
