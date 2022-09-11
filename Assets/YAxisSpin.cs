// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class YAxisSpin : MonoBehaviour
{
    [SerializeField] private float spinSpeed;

    private void Update()
    {
        transform.localRotation *=
            Quaternion.AngleAxis(this.spinSpeed * Time.deltaTime, Vector3.up);
    }
}