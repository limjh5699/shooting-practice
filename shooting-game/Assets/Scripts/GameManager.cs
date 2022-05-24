using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  private static int _score = 0;
  public static int Score
  {
    get
    {
      return _score;
    }
    set
    {
      _score = value;
      GameObject uiText = GameObject.FindWithTag("UIScore");
      if(uiText != null)
      {
        TextMeshProUGUI ui = uiText.GetComponent<TextMeshProUGUI>();
        ui.text = "SCORE : " + _score.ToString();
      }
    }
  }
 
  void Update()
  {
    if(_score > 10)
    {
      SceneManager.LoadScene("inWin");
    }
   }
}
