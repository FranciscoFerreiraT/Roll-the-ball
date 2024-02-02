using UnityEngine;

public class AutoRotateCamera : MonoBehaviour
{
    public Transform target; // Referencia al objeto que la c�mara seguir�
    public float rotationSpeed = 20f;

    void Update()
    {
        // Verifica si hay un objetivo asignado
        if (target == null)
        {
            Debug.LogWarning("No se ha asignado un objetivo a la c�mara.");
            return;
        }

        // Calcula el �ngulo de rotaci�n basado en el tiempo
        float angle = rotationSpeed * Time.deltaTime;

        // Rota la c�mara alrededor del objetivo
        transform.RotateAround(target.position, Vector3.up, angle);
    }
}
