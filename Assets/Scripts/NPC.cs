using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

[System.Serializable]
public class NPC : MonoBehaviour
{
    public Transform chatBackground;
    public Transform npcCharacter;

    private DialogueSystem dialogueSystem;

    bool playerHere = false;
    public string Name;

    [TextArea(5, 10)]
    public string[] sentences;

    void Start()
    {
        dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    void Update()
    {
        Vector3 Pos = Camera.main.WorldToScreenPoint(npcCharacter.position);
        Pos.y += 175;
        chatBackground.position = Pos;
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (playerHere && kb.spaceKey.wasPressedThisFrame)
        {
            this.gameObject.GetComponent<NPC>().enabled = true;
            dialogueSystem.Names = Name;
            dialogueSystem.dialogueLines = sentences;
            FindObjectOfType<DialogueSystem>().NPCName();
        }
    }

    public void OnTriggerStay(Collider other)
    {
        this.gameObject.GetComponent<NPC>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
        if ((other.gameObject.tag == "Player"))
        {
            playerHere = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            playerHere = false;
        }
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<NPC>().enabled = false;
    }
}
