using UnityEngine;

public class sphereBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(4.0f * Mathf.Sin(1.0f * Time.time), 4.0f * Mathf.Cos(1.0f * Time.time), 1.0f * Mathf.Cos(15.0f * Time.time));
    }
}
