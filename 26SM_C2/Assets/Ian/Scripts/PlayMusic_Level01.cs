using TMPro;
using UnityEngine;

public class PlayMusic_Level01 : MonoBehaviour
{
    [SerializeField]private string musicName;
    [SerializeField]private TMP_Text playerName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("PlayMusic_Level01");
    }


    public void ChangePlayerNameUI()
    {
        playerName.text = musicName;
    }
    
    
    
}
