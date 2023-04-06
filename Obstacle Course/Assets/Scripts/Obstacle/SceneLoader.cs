using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
   public void Next()
   {
        SceneManager.LoadScene(1);
   }

    public void Next2()
   {
        SceneManager.LoadScene(0);
   }
}
