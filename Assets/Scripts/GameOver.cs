using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text PointsText;
    
    public void SetUp(int score)
    {

        //foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        //{
        //if(o.tag == "MainCamera"  )
        //{
        //    continue;
        //}if(o.tag == "Gameover"
        //    )
        //{
        //    continue;
        //}
        //    Destroy(o);
        //}

       
        gameObject.SetActive(true);
       
        PointsText.text = "Score : "+score.ToString();
    }
    public void ResturtButtom()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
