using UnityEngine;

public class MovementDemo_Class04 : MonoBehaviour
{
    public float moveSpeed = 1f;

    private Rigidbody rb;
    [SerializeField]private Transform playerCube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GetComponent<Rigidbody>())
        {
            rb = GetComponent<Rigidbody>();
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (rb != null)
        {
            MoveByRigidbody();
        }
        else
        {
            MoveByTranslate();
        }


    }


    void MoveByTranslate()
    {
        //moveSpeed += Time.deltaTime;
        //playerCube.position = new Vector3(Input.GetAxis("Vertical") * 2, 0, 0);
        playerCube.Translate(Input.GetAxis("Vertical") * moveSpeed, 0,Input.GetAxis("Horizontal") * moveSpeed);
    }

    void MoveByRigidbody()
    {
        rb.linearVelocity = new Vector3(Input.GetAxis("Vertical") * moveSpeed, 0, Input.GetAxis("Horizontal") * moveSpeed);
    }
    
}
