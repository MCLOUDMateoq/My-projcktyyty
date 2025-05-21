using Unity.VisualScripting;
using UnityEngine;

public class PlayerRuchy : MonoBehaviour
{
    public float playerSpeed = 2;

    public Transform rightPath;
    public Transform leftPath;
    public Transform CenterPath;
    public Transform playerModel;
    public bool isCenter = true;    


    private void Update()
    {
        //PORUSZANIE GRACZA DO PRZODU
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        //JEŒLI KLIKNIEMY W PRAWO TO TELEPORT W PRAWO
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerModel.localPosition = rightPath.localPosition;


        }
        else if (isCenter == true && Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerModel.localPosition = leftPath.localPosition;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerModel.localPosition = leftPath.localPosition;
        }
        
    }
}
