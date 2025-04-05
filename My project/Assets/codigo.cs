using UnityEngine;

public class codigo : MonoBehaviour
{
    public float velocidad = 2f;

    void Start()
    {
         // Obtener el Rigidbody2D del personaje
    }

    void Update()
    {
       transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        
    }

    
}
