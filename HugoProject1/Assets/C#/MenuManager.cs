using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PLAY()
    { 
        SceneManager.LoadScene(0);
    }
    public void EXIT()
    { 
        Application.Quit();
    }

    public void QualityLevel(int _int)
    { 
        QualitySettings.SetQualityLevel(_int);
    }
    
    public void ToggleFullscreen()
    { 
        Screen.fullScreen = !Screen.fullScreen; 
    }
}
