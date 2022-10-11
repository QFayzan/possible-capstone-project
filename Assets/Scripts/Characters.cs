using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Characters : MonoBehaviour
{
    public Rigidbody rb;
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public int health;
    public static float jumpTimer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void BasicMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);
    }
    public void HealthSystem()
    {
        health = 3;
    }
    public void BounceUp(GameObject gameObject)
    {
        rb.AddForce(Vector3.up * 6, ForceMode.Impulse);
    }
    public void CanJump()
    {
        jumpTimer += Time.deltaTime;
        if (jumpTimer >3 && Input.GetKeyDown(KeyCode.Space))
            {
            rb.AddForce(Vector3.up * 3, ForceMode.Impulse);
            jumpTimer = 0;  
            }
    }
    public void Death()
    {
       Destroy(gameObject);
       SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
 }

