using UnityEngine;

public class AutoRotateCamera : MonoBehaviour
{
    public Transform target; // Referencia al objeto que la cámara seguirá
    public float rotationSpeed = 20f;

    void Update()
    {
        // Verifica si hay un objetivo asignado
        if (target == null)
        {
            Debug.LogWarning("No se ha asignado un objetivo a la cámara.");
            return;
        }

        // Calcula el ángulo de rotación basado en el tiempo
        float angle = rotationSpeed * Time.deltaTime;

        // Rota la cámara alrededor del objetivo
        transform.RotateAround(target.position, Vector3.up, angle);
    }
}
