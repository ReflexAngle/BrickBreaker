using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManageRounds : MonoBehaviour
{
    void Update(){
        EndRound();
        Debug.Log(bricks.Count);
    }

    [SerializeField] protected List<BrickScript> bricks; 
    [SerializeField] protected GameObject canvasScene;

    void Awake(){
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if(gOs.Length > 1){
            Destroy(gameObject);
        }
    }
    public void RemoveBrick(BrickScript bb){
        if (bricks.Count > 0 ){
            bricks.Remove(bb);
        }
        EndRound();
    }
    protected void EndRound(){
        if (bricks.Count <= 0 ){
            canvasScene.SetActive(true);

        }
    }
}
