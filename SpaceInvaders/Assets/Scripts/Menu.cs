using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    //When the player presses to play the game open the game screen
    public void PlayGame(){
        SceneManager.LoadScene(Constants.game);
    }

    //When the player presses to view the highscores open the highscores screen
    public void Highscores(){
        SceneManager.LoadScene(Constants.highscores);
    }

    //When the player presses to view the options open the options screen
    public void Options(){
        SceneManager.LoadScene(Constants.options);
    }

    //When the player presses to view the bonuses open the bonuses screen
    public void Bonuses(){
        SceneManager.LoadScene(Constants.bonuses);
    }

    //When the mouse is over the button change the colour of the buttons text to cyan
    public void OnMouseEnterButton(Text buttonText){
        buttonText.color = Color.cyan;
    }

    //When the mouse is no longer over the button change the colour of the buttons text to white
    public void OnMouseExitButton(Text buttonText){
        buttonText.color = Color.white;
    }
}
