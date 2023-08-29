using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private void Update()
    {
        // Move Up
        if (Input.GetKey(KeyCode.UpArrow))// W or Up
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // Move Down
        if (Input.GetKey(KeyCode.DownArrow)) //S or Down
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }

        // Move Left
        if (Input.GetKey(KeyCode.LeftArrow)) // A or Left
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Move Right
        if (Input.GetKey(KeyCode.RightArrow)) // D or Right
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }

}
