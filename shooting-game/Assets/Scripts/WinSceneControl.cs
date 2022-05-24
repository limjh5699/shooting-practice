using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneControl : MonoBehaviour
{
  void Update()
  {
    if(Input.anyKey)
    {
      GameManager.Score = 0;
      SceneManager.LoadScene("InGame");
    }
   }
}
