using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DialogueSystem : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public GameObject dialogueGUI;
    public Transform dialogueBoxGUI;

    public float letterDelay = 0.1f;
    public float letterMultiplier = 0.5f;

    public string Names;

    public string[] dialogueLines;

    public bool letterisMultiplied = false;
    public bool dialogueActive = false;
    public bool dialogueEnded = false;
    public bool outOfRange = true;

    public AudioClip audioClip;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dialogueText.text = "";
    }

    void Update()
    {
        
    }

    public void EnterRangeOfNPC()
    {
        outOfRange = false;
        dialogueGUI.SetActive(true);
        if (dialogueActive == true)
        {
            dialogueGUI.SetActive(false);
        }
    }

    public void NPCName()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        outOfRange = false;
        dialogueBoxGUI.gameObject.SetActive(true);
        nameText.text = Names;
        if (kb.spaceKey.wasPressedThisFrame)
        {
            if (!dialogueActive)
            {
                dialogueActive = true;
                StartCoroutine(StartDialogue());
            }
        }
        StartDialogue();
    }

    private IEnumerator StartDialogue()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (outOfRange == false)
        {
            int dialogueLength = dialogueLines.Length;
            int currentDialogueIndex = 0;

            while (currentDialogueIndex < dialogueLength || !letterisMultiplied)
            {
                if (!letterisMultiplied)
                {
                    letterisMultiplied = true;
                    StartCoroutine(DisplayString(dialogueLines[currentDialogueIndex++]));

                    if (currentDialogueIndex >= dialogueLength)
                    {
                        dialogueEnded = true;
                    }
                }
                yield return 0;
            }

            while (true)
            {
                if ((kb.spaceKey.wasPressedThisFrame) && dialogueEnded == false)
                {
                    break;
                }
                yield return 0;
            }
            dialogueEnded = false;
            dialogueActive = false;
            DropDialogue();
        }
    }
    private IEnumerator DisplayString(string stringToDisplay)
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (outOfRange == false)
        {
            int stringlength = stringToDisplay.Length;
            int currentCharacterIndex = 0;

            dialogueText.text = "";

            while (currentCharacterIndex < stringlength)
            {
                dialogueText.text += stringToDisplay[currentCharacterIndex];
                currentCharacterIndex++;

                if (currentCharacterIndex < stringlength)
                {
                    if (kb.spaceKey.wasPressedThisFrame)
                    {
                        yield return new WaitForSeconds(letterDelay * letterMultiplier);

                        if (audioClip) audioSource.PlayOneShot(audioClip, 0.5f);
                    }
                    else
                    {
                        yield return new WaitForSeconds(letterDelay);

                        if (audioClip) audioSource.PlayOneShot(audioClip, 0.5f);
                    }
                }
                else
                {
                    dialogueEnded = false;
                    break;
                }
            }
            while (true)
            {
                if (kb.spaceKey.wasPressedThisFrame)
                {
                    break;
                }
                yield return 0;
            }
            dialogueEnded = false;
            letterisMultiplied = false;
            dialogueText.text = "";
        }
    }

    public void DropDialogue()
    {
        dialogueGUI.SetActive(false);
        dialogueBoxGUI.gameObject.SetActive(false);
    }

    public void OutOfRange()
    {
        outOfRange = true;
        if (outOfRange == true)
        {
            letterisMultiplied = false;
            dialogueActive = false;
            StopAllCoroutines();
            dialogueGUI.SetActive(false);
            dialogueBoxGUI.gameObject.SetActive(false);
        }
    }
}
