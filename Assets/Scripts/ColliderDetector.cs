using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetector : MonoBehaviour
{
    RaycastHit hit;
    public UI ui;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Detector")
        {
            Debug.Log($"{other.name} gate passed");
            ui.updateScore(10);
            ui.updateHealth(ui.maxHealth);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Plane crashed. Game over");
        ui.showGameOverScreen();
    }

    void FixedUpdate()
    {
/*
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.Log($"Did Hit {hit.transform.name}");
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.magenta);*/

        // -------------------------
        //Tell us if we hit Beam only
        /*        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity) && hit.transform.name == "Beam")
                {
                    Debug.Log("Did Hit");
                }
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*hit.distance, Color.magenta);
        */
    }
}
