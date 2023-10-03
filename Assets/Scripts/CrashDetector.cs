using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

   [SerializeField] float reloadSceneDelay = 0.5f;
   private void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag == "Ground")
        {
           Invoke("ReloadScene", reloadSceneDelay);
        }
   }

   void ReloadScene()
   {
    SceneManager.LoadScene(0);
   }
}