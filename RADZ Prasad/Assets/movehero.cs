using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehero : MonoBehaviour
{
   

public GameObject snowBallCloneTemplate;
    Animator animator;
    float runningSpeed = 5f;

    Rigidbody rb;





    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            print("Could not find Animator Component");
        else
            print("Animator Component found");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowBallCloneTemplate, transform.position + transform.forward + Vector3.up, Quaternion.identity);
            snowballscript myNewSnowball = newSnowballGO.GetComponent<snowballscript>();
            myNewSnowball.throwSnowball(transform);


        }

        animator.SetBool("is running", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runningSpeed * transform.forward * Time.deltaTime;
            animator.SetBool("is running", true);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.down, 150 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= runningSpeed * transform.forward * Time.deltaTime;
            animator.SetBool("is running", true);
        }

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, 150 * Time.deltaTime);

        

    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);


        
        FootballScript myFootball = collision.gameObject.GetComponent<FootballScript>();
        if (myFootball != null)
        {
            myFootball.Kick();
        }

        
    }

}
