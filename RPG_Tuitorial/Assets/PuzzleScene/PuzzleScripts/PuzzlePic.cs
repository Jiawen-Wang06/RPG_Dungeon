using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuzzlePic : MonoBehaviour
{
    public string pieceStatus = "";
    public bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(clicked){
            if(pieceStatus != "locked"){
                Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = objPosition;
                
        }
        }
      
       
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == gameObject.name){
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
            clicked = false;
        }
    }
    
    private void OnMouseDown() {
        clicked = true;
    }
}
