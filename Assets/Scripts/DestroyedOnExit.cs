using UnityEngine;
using System.Collections;

public class DestroyedOnExit : MonoBehaviour
{
    void OnBecameInvisible() // Called when the object leaves the viewport
    {
        Destroy(gameObject);
    }
}
