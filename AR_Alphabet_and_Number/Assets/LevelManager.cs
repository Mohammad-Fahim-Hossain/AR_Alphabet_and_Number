using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void QuitApp() {

        Application.Quit();

    }

    public void EnglishAlphabetScene() {

        SceneManager.LoadScene("EnglishAlphabet");

    }

    public void EnglishNumberScene() {

        SceneManager.LoadScene("EnglishNumber");

    }

    public void BanglaAlphabetScene() {

        SceneManager.LoadScene("BanglaAlphabet");

    }

    public void BanglaNumberScene() {

        SceneManager.LoadScene("BanglaNumber");

    }

    public void MainManu() {

        SceneManager.LoadScene("MainManu");

    }

}
