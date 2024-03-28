using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class playercollison : MonoBehaviour
{
    public GameController controller;
    public Score score;
    public NewBehaviourScript playerScript;
    public AudioSource audioSource;
    public AudioSource gameover;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectables")
        {
            score.AddScore(1);
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="obstacle")
        {
            controller.GameOver();
            playerScript.enabled = false;
            gameover.Play();
        }
    }

}
