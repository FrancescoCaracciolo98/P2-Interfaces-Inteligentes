using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
  private ScoreCharacter score;

  [Range(1.0f, 30.0f)]
  public float speedMovement = 10f;
  public float speedRotation = 90f;
  public float punctuation = 0f;

  void Start () {
    score = GameObject.FindObjectOfType<ScoreCharacter>();
  }

  void Update() {
    transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speedMovement);
    transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speedMovement);
    if (Input.GetKey("e")) {
      transform.Rotate(0, 0, Time.deltaTime * (-speedRotation));
    } 
    if (Input.GetKey("q")) {
      transform.Rotate(0, 0, Time.deltaTime * speedRotation);
    }
  }

  void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "FirstCylinder") {
      punctuation++;
      score.UpdateScoreText(punctuation);
    }
  }
}
