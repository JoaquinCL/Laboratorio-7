/*
 
-El Sol tiene que estar en el punto central del escenario. Rota sobre su propio eje.
-La Tierra tiene que estar a una distancia n del Sol, y girar alrededor de este. Asimismo, la Tierra debe girar sobre su propio eje.
-La Luna tiene que estar a una distancia peque�a de la Tierra, y girar alrededor de esta. Asimismo, la Luna gira sobre su propio ejes
-El sat�lite artificial debe estar a una distancia peque�a de la Tierra, mucho menor que el de la Luna, y girar alrededor de esta. La rotaci�n del sat�lite debe estar ajustada para siempre est� mirando al Sol.

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSimple : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up;
    public float rotationSpeed = 50.0f;

    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
