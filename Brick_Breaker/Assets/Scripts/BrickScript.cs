using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Bradley Petersen
//  02 - 08 - 2025
public class BrickScript : MonoBehaviour
{
    [SerializeField, Range(1, 5)] protected int hitsToBreak;
    protected int curHitsToBreak = 0;

    void Awake(){
        curHitsToBreak = hitsToBreak;
    }
    void Update(){

    }
    // brick's health
    public void Break(int aDamage){
        curHitsToBreak -= aDamage;
        BreakBrick();

    }
    // destroy the brick
    protected void BreakBrick(){
        if(curHitsToBreak < 0){
            Destroy(gameObject);
            FindObjectOfType<ManageRounds>().RemoveBrick(this);
        }
        

    }
}
