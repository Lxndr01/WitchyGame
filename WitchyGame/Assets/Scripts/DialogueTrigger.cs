using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
<<<<<<< HEAD
    public Dialogue dialogueScript;
    private bool playerDetected;

    //Detect trigger with player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If we triggerd the player enable playerdeteced and show indicator
        if (collision.tag == "Player")
        {
            playerDetected = true;
            dialogueScript.ToggleIndicator(playerDetected);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //If we lost trigger  with the player disable playerdeteced and hide indicator
        if (collision.tag == "Player")
        {
            playerDetected = false;
            dialogueScript.ToggleIndicator(playerDetected);
            dialogueScript.EndDialogue();
        }
    }
    //While detected if we interact start the dialogue
    private void Update()
    {
        if (playerDetected && Input.GetKeyDown(KeyCode.E))
        {
            dialogueScript.StartDialogue();
        }
=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
>>>>>>> 1a0c1b99b4b327bfa884496fb8b782958f02af4b
    }
}
