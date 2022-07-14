using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveScript : MonoBehaviour
{
    public PlayerParty playerParty;
    public Transform playerTransform;
    Vector2 lastClickedPos;
    
    private void Start()
    {
  
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(lastClickedPos); 
        }

        float move = playerParty.partySpeed * Time.deltaTime;
        playerTransform.position = Vector2.MoveTowards(playerTransform.position, lastClickedPos, move);
    
    }
}
