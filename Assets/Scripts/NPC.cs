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

    public string Name;

    [TextArea(5, 10)]
    public string[] sentences;

    private void Start()
    {
        dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    void Update()
    {
        Vector3 Pos = Camera.main.WorldToScreenPoint(npcCharacter.position);
        Pos.y += 175;
        chatBackground.position = Pos;
    }

    public void OnTriggerStay(Collider other)
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        this.gameObject.GetComponent<NPC>().enabled = true;
        FindObjectOfType<DialogueSystem>().EnterRangeOfNPC();
        if ((other.gameObject.tag == "Player") && kb.spaceKey.wasPressedThisFrame)
        {
            this.gameObject.GetComponent<NPC>().enabled = true;
            dialogueSystem.name = Name;
            dialogueSystem.dialogueLines = sentences;
            FindObjectOfType<DialogueSystem>().NPCName();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        FindObjectOfType<DialogueSystem>().OutOfRange();
        this.gameObject.GetComponent<NPC>().enabled = false;
    }
}
