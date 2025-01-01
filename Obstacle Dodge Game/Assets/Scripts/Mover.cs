using UnityEngine;

public class Mover : MonoBehaviour
{
   
   [SerializeField]float moveSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("To move, use the WASD or arrow keys.");
        Debug.Log("The object of the game is to get from the start to finish without hitting obstacles.");

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}
