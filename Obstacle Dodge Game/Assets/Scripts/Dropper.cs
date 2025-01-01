using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]int timeToWait = 3;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
      Drop();
    }

    void Drop(){
          if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true; 
        }
    }
}
