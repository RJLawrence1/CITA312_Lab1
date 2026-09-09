using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }
    
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using the arrow keys or WASD!");
        Debug.Log("Don't bump into the objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
