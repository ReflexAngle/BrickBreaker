using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// Bradley Petersen
//  02 - 08 - 2025
public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int playerScore = 0;


    public void ResetScore(){
        if (playerScore > 0){
            playerScore = 0;
        }else if ( playerScore < 0 /*for some reason*/){
            playerScore = 0;
        }

//this
    }

    public static GameManager Instance{
        get{
            if (instance == null){
                GameObject aGO = new GameObject("Game Manager");
                instance = aGO.AddComponent<GameManager>();
                DontDestroyOnLoad(aGO);
            }
            return instance;
        }

    }
    void OnEnable(){

    }
    void OnDisable(){

    }
    void Awake(){

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
