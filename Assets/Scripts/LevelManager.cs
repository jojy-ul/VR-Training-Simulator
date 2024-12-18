using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLabScene()
    {
        SceneManager.LoadScene("LabScene");
    }

    public void Equipment_Familiarization()
    {
        SceneManager.LoadScene("Equipment_Familiarization");
    }
    
    public void Safety_Training()
    {
        SceneManager.LoadScene("Safety_Training");
    }
    
    public void Login_Scene()
    {
        SceneManager.LoadScene("Login");
    } 
    
    public void Dashboard_Scene()
    {
        SceneManager.LoadScene("DashBoard");
    }
    
    public void Tutorial_Scene()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
