using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
    [SerializeField] float period = 2f;
    [SerializeField] float movementOffset = 0.5f;
    float movementFactor;
    Vector3 StartingPos;
    private void Start()
    {
        StartingPos = transform.position;
    }
    void Update()
    {
        if (period <= Mathf.Epsilon)
        {
            return;
        }
        float cycle = Time.time / period;
        const float tau = Mathf.PI * 2f;
        float sinewave = Mathf.Sin(cycle * tau);
        movementFactor = sinewave / 2f + movementOffset;
        Vector3 offset = movementFactor * movementVector;
        transform.position = StartingPos + offset;
    }
   
}
