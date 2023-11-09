using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10f; // Adjust bullet speed as needed
        rb.velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with a wall object and the colliding object is the bullet clone
        if (collision.gameObject.tag == "Wall" && collision.gameObject != this.gameObject)
        {
            // Destroy the bullet clone
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "CornerWall")
        {
            // Destroy all floor panels
            DestroyAllFloorPanels();
        }
    }

    void DestroyRandomFloorPanel()
    {
        // Get a list of all floor panel objects
        GameObject[] floorPanels = GameObject.FindGameObjectsWithTag("FloorPanel");

        // Select a random floor panel to destroy
        int randomIndex = Random.Range(0, floorPanels.Length);
        GameObject floorPanelToDestroy = floorPanels[randomIndex];

        // Destroy the selected floor panel
        Destroy(floorPanelToDestroy);
    }

    void DestroyAllFloorPanels()
    {
        // Get a list of all floor panel objects
        GameObject[] floorPanels = GameObject.FindGameObjectsWithTag("FloorPanel");

        // Destroy all floor panels
        for (int i = 0; i < floorPanels.Length; i++)
        {
            Destroy(floorPanels[i]);
        }
    }
}