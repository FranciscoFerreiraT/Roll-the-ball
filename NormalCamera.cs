using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player; // Necesitas asignar el jugador desde el Inspector
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player not assigned to CameraController script.");
            return;
        }

        offset = transform.position - player.position;
    }

    // LateUpdate se usa comúnmente para manipulaciones de cámara después de que todos los objetos han sido procesados en Update.
    void LateUpdate()
    {
        if (player == null)
        {
            Debug.LogError("Player not assigned to CameraController script.");
            return;
        }

        transform.position = player.position + offset;
    }
}