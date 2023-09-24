using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Button playButton; // Attach your button here through inspector
    private bool isGameRunning;

    void Start()
    {
        // Register button click event
        playButton.onClick.AddListener(OnPlayButtonClick);

        // Initially game is not running
        isGameRunning = false;
    }

    void Update()
    {
        if(isGameRunning)
        {
            // Your game loop logic here, which will run every frame once the play button is clicked
            Debug.Log("Game is Running");
        }
    }

    void OnPlayButtonClick()
    {
        // Start the game loop when play button is clicked
        isGameRunning = true;
        
        // Optionally, you can disable the play button after it is clicked
        playButton.interactable = false;
    }
}

