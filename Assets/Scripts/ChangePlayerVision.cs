using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerVision : MonoBehaviour
{
    [SerializeField] private GameObject redVision;
    [SerializeField] private LayerMask normalMask;
    [SerializeField] private LayerMask poweredMask;
    [SerializeField] private Camera persoCamera;
    private float maxTimePower = 10;
    private float timeActivePower = 10;
    private bool asActivePower = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeActivePower();
        }
    }

    private void ChangeActivePower()
    {
        if (asActivePower)
        {
            Debug.Log("Disable power, back to normal");
            asActivePower = false;
            redVision.SetActive(false);
            persoCamera.cullingMask = normalMask;
        }
        else
        {
            Debug.Log("Change Color, Activate power");
            asActivePower = true;
            redVision.SetActive(true);
            persoCamera.cullingMask = poweredMask;
        }
    }
}
