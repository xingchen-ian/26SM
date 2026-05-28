using UnityEngine;

public class Movement_Test : MonoBehaviour
{
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        
    }


    void TranslateObject()
    {
        //Input.GetAxis("Vertical") means using the pair of W Key and S Key
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        
        //Input.GetAxis("Horizontal") means using the pair of A Key and D Key
        float z = Input.GetAxis("Vertical") * moveSpeed;
        
        // the "Transform" is different from the "transform"
        // "Transform" is the very root Class,
        // "transform" refers to the transform component that attached to object having this script.
        // "Translate" is a function of moving objects.
        transform.Translate(x, 0, z, Space.Self);
    }
    
    void MoveRigidbodyObject()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, 0, Input.GetAxis("Vertical") * moveSpeed);
    }
    
    
}
