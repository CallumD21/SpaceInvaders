﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    //True if the game music is playing
    private bool playing = true;

	private void Start(){
        //Make OnLevelLoaded get called when a new scene is loaded
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void OnDestroy(){
        //Remove OnLevelLoaded
        SceneManager.sceneLoaded -= OnLevelLoaded;
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode){
        //If the game is loaded stop playing the music
        if (scene.buildIndex == 2){
            GetComponent<AudioSource>().Stop();
            playing = false;
        }
        //If a scene is loaded other than the game and the music isnt playing then play it
        else if (!playing){
            GetComponent<AudioSource>().Play();
            playing = true;
        }
    }
}
