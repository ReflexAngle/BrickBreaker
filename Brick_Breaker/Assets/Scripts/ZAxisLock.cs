using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
// Bradley Petersen
//  02 - 08 - 2025
public class ZAxisLock : MonoBehaviour
{
    protected Rigidbody rb;
    [SerializeField] private Vector3 startForce = Vector3.one;  
    [SerializeField] protected float worldVelocity = 25f;
    [SerializeField] private int damage = 1;
    void OnEnable(){
        rb = GetComponent<Rigidbody>();
        applyForce();
        
    }
    // Start is called before the first frame update
    void Awake()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LimitBallVelocity();
        
    }
    // limits the ball velocity to preven it from picking up to much speed
    private void LimitBallVelocity(){
        Vector3 HV3 = rb.velocity;
        Vector3 NV3 = Vector3.zero;

        NV3.x = Mathf.Clamp(HV3.x, -worldVelocity, worldVelocity);
        NV3.y = Mathf.Clamp(HV3.y, -worldVelocity, worldVelocity);
        NV3.z = Mathf.Clamp(HV3.z, -worldVelocity, worldVelocity);

        rb.velocity = NV3;
    }
    // I dont like using inheritance
    private void applyForce(){
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision){
        BrickScript bb = collision.gameObject.GetComponent<BrickScript>();
        if(bb != null){
            bb.Break(damage);
        }
    }
}
