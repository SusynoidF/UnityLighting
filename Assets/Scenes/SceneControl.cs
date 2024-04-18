using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{ 
   public void Beep()
   {
    SceneManager.LoadScene("New Scene");
   }
   public void Boop()
   {
   SceneManager.LoadScene("Old Scene");
   }

   
}
