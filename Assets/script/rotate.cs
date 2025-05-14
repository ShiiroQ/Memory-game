using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform orientation;
    public GameManager gameManager;
    public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation();
    }

    public void rotation()
    {
        if (gameManager.rotatation)
        {

            transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }

    }
}
