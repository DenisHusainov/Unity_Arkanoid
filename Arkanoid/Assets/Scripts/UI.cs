using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    [SerializeField]private Text text;
    
    private MoveBall ballPoints;

    private void Start()
    {
      
        ballPoints = MoveBall.Instance;
    }

    private void Update()
    {
        text.text = "Score:" + ballPoints.points;
        if (ballPoints.points>9)
        {
            text.text = "You Win!";
            Time.timeScale = 0;
        }
        if (ballPoints.lose == true)
        {
            text.text = "Loseeer!";
            
        }
    }





}
