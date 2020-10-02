using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    private bool hasSafeArea = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        hasSafeArea = ((Screen.width == Screen.safeArea.width) && (Screen.height == Screen.safeArea.height)) ? false : true;

        switch(Screen.orientation)
        {
            
            case ScreenOrientation.Portrait:
                //Debug.Log("Portrait");
                //SceneLabel.text = "Portrait";
                if(hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(351.0f, -206.5f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-360.0f, -206.53f);
                }
                else
                {

                }
                break;
            case ScreenOrientation.LandscapeLeft:
                //Debug.Log("LandscapeLeft");
                //SceneLabel.text = "LandscapeLeft";
                if(hasSafeArea)
                {
                LivesLabel.rectTransform.anchoredPosition = new Vector2(494.0f, -206.5f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-360.0f, -206.5f);
                }
                else
                {

                }

                break;
            case ScreenOrientation.LandscapeRight:
                //Debug.Log("LandscapeRight");
                //SceneLabel.text = "LandscapeRight";
                break;
            case ScreenOrientation.Unknown:
                //Debug.Log("Unknown");
                //SceneLabel.text = "Unknown";
                break;
            default:
                //Debug.Log("Some other orientation");
                //SceneLabel.text = "Some other orientation";
                break;
        }
    }
}
