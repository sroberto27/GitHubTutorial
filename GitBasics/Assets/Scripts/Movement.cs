using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private void Update()
    {
        // Move Up
        if (Input.GetKey(KeyCode))// W or up
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // Move Down
        if (Input.GetKey(KeyCode)) //S or down
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        // Move Left
        if (Input.GetKey(KeyCode)) // A or left
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Move Right
        if (Input.GetKey(KeyCode)) // D or right
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

}