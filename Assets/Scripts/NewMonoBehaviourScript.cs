using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float playerSpeed = 2;
    void Update() => transform.Translate(Vector3.forward * playerSpeed);
}
