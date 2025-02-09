using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
// Bradley Petersen
//  02 - 08 - 2025

public class CanvasNav : MonoBehaviour
{
    // transitions the scene fprward
    public void LoadNextScene(int aSceneID){ // did you know the tool in the editor can find lambda functions I didnt
        SceneManager.LoadScene(aSceneID);
    }
    // sends us back to the start
    public void LoadStart(){
        LoadNextScene(0);
    }
}
