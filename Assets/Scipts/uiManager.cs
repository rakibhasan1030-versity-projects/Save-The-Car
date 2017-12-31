using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class uiManager : MonoBehaviour {

    public Image playPauseImage;
    int score;
    public Button[] buttons;
    public AudioManager am;
    Toggle toogleBtn;
    

    void Start () {
        
    }
	void Update () {
      
    }


    public void gameOverActivated()
    {
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Play()
    {
        StartCoroutine(LoadingLevel1());
    }

    IEnumerator LoadingLevel1()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level 2");
    }


    public void Option()
    {
        StartCoroutine(LoadingLevel2());
    }
    IEnumerator LoadingLevel2()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("optionScene");
    }



    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            playPauseImage.sprite = Resources.Load<Sprite>("Play-icon");
            am.carSound.Stop();

        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            playPauseImage.sprite = Resources.Load<Sprite>("pause-button");
            am.carSound.Play();
        }

    }

    public void Menu()
    {
        StartCoroutine(LoadingLevel());
    }

    IEnumerator LoadingLevel()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("menuScene");

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void disablePause()
    {
        playPauseImage.enabled = false;
    }

}
