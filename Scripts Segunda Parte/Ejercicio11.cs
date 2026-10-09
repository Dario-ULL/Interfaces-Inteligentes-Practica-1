using System.Collections;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    [Header("Objetivo")]
    [Tooltip("Referencia al Transform de la esfera")]
    public Transform objetivoEsfera;
    [Header("Configuración de Movimiento")]
    [Tooltip("Velocidad constante de avance")]
    public float speed = 3.0f;

    void Start()
    {
        if (objetivoEsfera == null)
        {
            GameObject esferaGO = GameObject.Find("Sphere");
            if (esferaGO != null)
            {
                objetivoEsfera = esferaGO.transform;
            }
        }
    }

    void Update()
    {
        if (objetivoEsfera == null) return;
        Vector3 objetivo = new Vector3(
          objetivoEsfera.position.x,
          transform.position.y,
          objetivoEsfera.position.z
        );
        Vector3 direccion = objetivo - transform.position;
        if (direccion.magnitude > 0.05f)
        {
            transform.Translate(direccion * speed * Time.deltaTime, Space.Self);
        }
    }
}
