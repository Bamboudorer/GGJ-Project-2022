using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActivationScript : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;
    [SerializeField] private bool activateAnimation = false;
    [SerializeField] private Animator doorAnimator;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Open the Door");
            activateAnimation = !activateAnimation;
            // doorAnimator.SetBool("StartAction", true);
            doorAnimator.SetBool("DoorOpen", activateAnimation);
        }
        // doorAnimator.SetBool("StartAction", activateAnimation);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }
}
