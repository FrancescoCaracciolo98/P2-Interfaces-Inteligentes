using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCharacter : MonoBehaviour
{
    
  public Text pointText;

    void Update() {
    }

    public void UpdateScoreText(float score) {
        pointText.text = score.ToString();    
    }


}
