using System.Collections;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
