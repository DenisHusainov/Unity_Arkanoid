using UnityEngine;




public class MoveBall : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [HideInInspector] public int points = 0;
    [HideInInspector] public bool lose;
    private AudioManager audioManager;
    public static MoveBall Instance;


    private void Awake()
    {
        Instance = this;
        lose = false;
        Time.timeScale = 1;
       
    }
  
    void Start()
    {

        audioManager = AudioManager.Instance;
        rigidbody.velocity = new Vector2(10f, 10f);
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lose"))
        {
            audioManager.AudioLoseBorder();
            lose = true;
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("Block"))
        {
            audioManager.AudioBlock();
            points++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Border"))
        {
            audioManager.AudioBorder();
        }


    }
    

}
