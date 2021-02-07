using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Space : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
