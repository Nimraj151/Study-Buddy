using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
 public void playGame()
 {
    SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);

 }

 public void GoToSettingsMenu()
 {
    SceneManager.LoadScene("SettingsMenu");
 }

public void GoToMainMenu()
 {
    SceneManager.LoadScene("MainMenu");
 }

 public void Back()
 {
    Application.Quit();
 }

}
