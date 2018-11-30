using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour {

    //When the home button is pressed open the menu
	public void Home(){
        SceneManager.LoadScene(Constants.menu);
    }
}