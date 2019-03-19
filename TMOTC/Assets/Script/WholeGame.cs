using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.UI;


public class WholeGame : MonoBehaviour
{
    public int _answerstate = 0;
    public int _goodanswer = 0;
    public int _badanswer = 0;
    public TextMeshProUGUI leftanswer;        
    public TextMeshProUGUI rightanswer;
    public Button b1; // left button
    public Button b2; // right button
    
    //right so these were calling buttons but didn't use UI or onClick
    //public Button rightbut;
    //public Button leftbut;

    public TextMeshProUGUI speech;
    public Sprite[] cat;
    public SpriteRenderer catsprite;

    // Start is called before the first frame update
    void Start()
    {
        b1.onClick.AddListener(ClickHandlerRightButton);
        b2.onClick.AddListener(ClickHandlerLeftButton);
       // ButtonChoices();
    }

    // Update is called once per frame

    public void Choices()
    {
        if (_answerstate == 0)
        {
            speech.text = "Are you a Night Owl or Early Bird?";
            leftanswer.text = "Night Owl.";
            rightanswer.text = "Early Bird!";
            catsprite.sprite = cat[10];
            _answerstate++;



        }
        else if (_answerstate == 1)
        {
            speech.text = "What do you like on your pizza?";
            leftanswer.text = "Gotta love greens";
            rightanswer.text = "I'm all about anchovies";
            catsprite.sprite = cat[4];
            _answerstate++;
            //failed attempts
//            if (b1)
//            {
//                ClickHandlerCorrect();
//            }
//
//            if (b2)
//            {
//                ClickHandlerWrong();
//            }
            
            
        }
        else if (_answerstate == 2)
        {
            speech.text = "Are you allergic to cats?";
            leftanswer.text = "Nah.";
            rightanswer.text = "Yes dude, get away!";
            catsprite.sprite = cat[9];
            _answerstate++;
//old code left in to remind me what not to do
//            if (leftbut)
//            {
//                _badanswer++;
//                catsprite.sprite = cat[9];
//            }
//            else if (rightbut)
//            {
//                _goodanswer++;
//                catsprite.sprite = cat[3];
//            }
        }
        else if (_answerstate == 3)
        {
            speech.text = "How do you feel about naps?";
            leftanswer.text = "Hate 'em.";
            rightanswer.text = "Love 'em!";
            catsprite.sprite = cat[6];
            _answerstate++;

//            if (leftbut)
//            {
//                _badanswer++;
//                catsprite.sprite = cat[1];
//            }
//            else if (rightbut)
//            {
//                _goodanswer++;
//                catsprite.sprite = cat[3];
//            }
        }
        else if (_answerstate == 4)
        {
            speech.text = "Don't you hate birds?";
            leftanswer.text = "They're the worst!";
            rightanswer.text = "Not really man.";
            catsprite.sprite = cat[3];
            _answerstate++;
//            if (leftbut)
//            {
//                _goodanswer++;
//                catsprite.sprite = cat[3];
//            }
//            else if (rightbut)
//            {
//                _badanswer++;
//                catsprite.sprite = cat[3];
//            }
        }
        else if (_answerstate == 5)
        {
            speech.text = "Alright, can I have some belly rubs?";
            leftanswer.text = "Sure Thing!";
            rightanswer.text = "I dont know...";
            catsprite.sprite = cat[7];
            _answerstate++;

//            if (leftbut)
//            {
//                _goodanswer++;
//                catsprite.sprite = cat[3];
//            }
//            else if (rightbut)
//            {
//                _badanswer++;
//                catsprite.sprite = cat[6];
//            }
        }
        else if (_answerstate == 6)
        {
            ChangeSpeech();
        }
    }


    void ClickHandlerLeftButton()
    {
        if (_answerstate % 2 == 0)
        {
            _badanswer++;
        }
        else
        {
            _goodanswer++;
        }
        // do the things you want it to do
    }

    void ClickHandlerRightButton()
    { 
        if (_answerstate % 2 == 0)
        {
            _goodanswer++;
        }
        else
        {
            _badanswer++;
        }

    }

    void ButtonChoices()
    {
        //switch added listener each time it was called
//        switch (_answerstate % 2)
//        {
//            case 0:
//                b1.onClick.Invoke();
//                b2.onClick.Invoke();
//                break;
//            case 1:
//                b2.onClick.AddListener(ClickHandlerCorrect);
//                b1.onClick.AddListener(ClickHandlerWrong);
//                break;
//        }
        b1.onClick.Invoke();
        b2.onClick.Invoke();
        
        
    } 


    void ChangeSpeech()
    {
        if (_goodanswer > _badanswer)
        {
            speech.text = "You can totally be my roommate then!";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            speech.text = "You can't live with me man...";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[0];
        }

    }
}
    

    
