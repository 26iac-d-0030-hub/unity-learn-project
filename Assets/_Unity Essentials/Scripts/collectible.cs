using UnityEngine;

public class collectible : MonoBehaviour
{
    public GameObject specialEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.5f,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Create special effect object
        Instantiate(specialEffect, transform.position, transform.rotation);

        //Destroy this object
        Destroy(gameObject);
    }
}
