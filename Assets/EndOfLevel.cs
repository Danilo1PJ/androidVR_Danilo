using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{
    public void EndOfGame()
    {
        //Debug.Log("HIT");
        //Application.Quit();
        SceneManager.LoadScene("fps");
    }
}
