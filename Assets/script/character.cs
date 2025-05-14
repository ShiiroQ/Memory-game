using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class character : MonoBehaviour
{
    public float characterSpeed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mouvement();
      
    }

   

    public void Mouvement()
    {
        
        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 vitesse = new Vector3  (0,0,characterSpeed);
            transform.position = transform.position + vitesse * Time.deltaTime  ;
        }
    }
}
