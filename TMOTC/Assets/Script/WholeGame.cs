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
            speech.text = "What do you think of fish?";
            leftanswer.text = "They're good enough to eat!";
            rightanswer.text = "Pretty fish are crucial to the environment.";
            catsprite.sprite = cat[10];
            _answerstate++;



        }
        else if (_answerstate == 1)
        {
            speech.text = "When do you like visiting the beach?";
            leftanswer.text = "Daytime! Where the sun is blinding!";
            rightanswer.text = "Usually at night, where I can see the stars.";
            catsprite.sprite = cat[4];
            _answerstate++;
           
            
        }
        else if (_answerstate == 2)
        { 
            AltPath();
//            speech.text = "Are you allergic to cats?";
//            leftanswer.text = "Nah.";
//            rightanswer.text = "Yes dude, get away!";
//            catsprite.sprite = cat[9];
//            _answerstate++;
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

    void AltPath()
    {
        if (_goodanswer > _badanswer)
        {
            _answerstate++;
            speech.text = "You like stars huh? What about them?";
            leftanswer.text = "They remind me about how little we are.";
            rightanswer.text = "They're just neat.";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            _answerstate++;
            speech.text = "...What's so nice about the sun?";
            leftanswer.text = " It big. Space big too.";
            rightanswer.text = "Warm and toasty!";
            catsprite.sprite = cat[0];
        }
        else if (_goodanswer == _badanswer)
        {
            _answerstate++;
            speech.text = "Forget the beach then. What about space?";
            leftanswer.text = "Cool stuff. I like aliens.";
            rightanswer.text = "Neat. But I like beach more.";
        }
    }

    void ChangeSpeech()
    {
        if (_goodanswer > _badanswer)
        {
            speech.text = "Thanks, I'm glad I met someone as nice as you! Goodbye now!";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            speech.text = "Sorry pal, you're better as food than friend.";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[0];
        }
        else if (_goodanswer == _badanswer)
        {
            speech.text = "You've found me out! Gotta blast!";
            leftanswer.text = " ";
            rightanswer.text = " ";
        }
    }
}
    

    
