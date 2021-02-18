using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // I created this just to make Main menu work.
   private void Update() { Cursor.visible = true; }
    public void Level1()
    { SceneManager.LoadScene(1); }
    public void Exit()
    { Application.Quit();  print("LEAVING, OH WAIT"); }
}
