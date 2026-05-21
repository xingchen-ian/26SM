using UnityEngine;

public class LightControl : MonoBehaviour
{
    public Light lightOBJ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("LightControl.Start");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("LightControl.Update");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Space Pressed");
            lightOBJ.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            lightOBJ.enabled = true;
        }
        
    }
}
