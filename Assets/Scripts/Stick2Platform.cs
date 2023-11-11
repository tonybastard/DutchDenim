using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stick2Platform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Guy")
        {
            collision.gameObject.transform.SetParent(transform);

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Guy")
        {
            collision.gameObject.transform.SetParent(null);

        }
    }
}
