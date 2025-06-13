using TMPro; // Ensure you have the TextMeshPro package installed
using UnityEngine;
using UnityEngine.UI;

public class ManegerScore : MonoBehaviour
{
  // Start is called once before the first execution of Update after the MonoBehaviour is created



  [SerializeField] private Transform ball;
  [SerializeField] int scorePlayer1, scorePlayer2, scoreMax;

  bool player1Scored, player2Scored;
  public TMP_Text txtPlay1, txtPlay2;

  [SerializeField] private GameObject gameOverPanel;

  public delegate void ResetPositionball(bool reset);
  public static event ResetPositionball OnResetPosition;

  void Start()
  {


  }

  // Update is called once per frame
  void Update()



  {
    Score(player1Scored, player2Scored); // Call the score method to check if a player scored
    IsBallScreem();

    if (scorePlayer1 >= scoreMax || scorePlayer2 >= scoreMax)
    {
      GameOver();



    }

  }



  void Score(bool player1Score, bool player2Score)
  {
    // This method is intended to update the score based on which player scored
    // Implement the logic to update the score and UI text


    if (player1Score && scorePlayer1 < scoreMax)
    {

      // Debug.Log("Score method called with player1Score: " + player1Score + ", player2Score: " + player2Score);


      Debug.Log("Ponto player 1!");
      if (OnResetPosition != null) { OnResetPosition(player1Score); }


      scorePlayer1++;
      txtPlay1.text = scorePlayer1.ToString();


      //Debug.Log("Score method called with player1Score: " + player1Score + ", player2Score: " + player2Score);



    }
    else if (player2Score && scorePlayer2 < scoreMax)
    {

      Debug.Log("Ponto player 2!");
      if (OnResetPosition != null) { OnResetPosition(player2Score); }

      scorePlayer2++;
      txtPlay2.text = scorePlayer2.ToString();



      //Debug.Log("Score method called with player1Score: " + player1Score + ", player2Score: " + player2Score);

    }


  }


  void IsBallScreem()
  {



    // This method is intended to check if the ball has scored
    // Implement the logic to determine if the ball has gone out of bounds or scored

    Vector2 ballPosition = ball.position;

    float screenWidth = Camera.main.orthographicSize * Camera.main.aspect; //largora

    // Calculate the screen width based on the camera's orthographic size and aspect ratio
    float screenHeight = Camera.main.orthographicSize * 2f; // altura


    // Calculate the screen height based on the camera's orthographic size


    if (ballPosition.x < -screenWidth)
    {
      // Ball is out of bounds, implement scoring logic here
      Debug.Log("Ponto player 2!");
      player2Scored = true;



      // Reset the ball position or update the score as needed
    }
    else if (ballPosition.x > screenWidth)
    {
      // Ball is out of bounds, implement scoring logic here
      Debug.Log("Ponto player 1!");
      player1Scored = true;



      // Reset the ball position or update the score as needed
    }
    else
    {

      player1Scored = false;
      player2Scored = false;
    }

    Debug.Log("Ball Position: " + ballPosition.x + ", " + ballPosition.y);
    //  Debug.Log("Screen Width: " + screenWidth + ", Screen Height: " + screenHeight);
  }


  void GameOver()
  {
    // This method is intended to handle the game over logic
    // Implement the logic to display a game over screen or reset the game



    if (gameOverPanel != null) gameOverPanel.SetActive(true);
    OnResetPosition(false);


    Debug.Log("Game Over!");
    // Display game over panel or reset the game
    // ShowGameOverPanel();
    // Optionally, reset scores or perform other actions
  }

}





