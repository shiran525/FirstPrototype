using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    private Animator animator;
    private void Start()
    {
        speed = 5;
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        bool walking = Input.GetKey(KeyCode.W);
        animator.SetBool("walking", walking);
        if (walking)
        {

          transform.Translate((transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal")).normalized * speed * Time.deltaTime*0.1f);
         transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime*0.1f);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("attack");

        }

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
       public void sceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
