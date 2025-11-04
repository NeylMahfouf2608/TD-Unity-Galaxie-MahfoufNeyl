using UnityEngine;

public class Orbite : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject sun;
    [SerializeField] float orbitSpeed;
    [SerializeField] float rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = sun.transform.position - this.transform.position;
        transform.position = (sun.transform.position - distance);
        transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        

    }
}
