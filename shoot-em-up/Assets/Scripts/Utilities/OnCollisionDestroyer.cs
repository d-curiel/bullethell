using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.SetActive(false);
    }
}
