using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
  
    public void clickPlay()
    {
        SceneManager.LoadScene("gameplay");
        Data.score = 0;
    }

    public void clickReplay()
    {
        SceneManager.LoadScene("gameplay");
        Data.score = 0;
    }

    public void clickMenu()
    {
        SceneManager.LoadScene("mainmenu");
        Data.score = 0;
    }
}
