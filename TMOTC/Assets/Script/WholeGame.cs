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
        }
        else if (_answerstate == 3)
        {
            AltPath2();

        }
        else if (_answerstate == 4)
        {
            speech.text = "*Sigh* Alright, I'll let you in on a secret. A secret to make you my friend.";
            leftanswer.text = "Oh really? I'm so ready for it!";
            rightanswer.text = "Do I have know? I don't really care.";
            catsprite.sprite = cat[3];
            _answerstate++;    
        }
        else if (_answerstate == 5)
        {
            speech.text = "I'm not from around here...";
            leftanswer.text = "A lot of people are. Your point?";
            rightanswer.text = "Like, from another country? That's fine!";
            catsprite.sprite = cat[7];
            _answerstate++;

        }
        else if (_answerstate == 6)
        {
           AltPath3();
        }
        else if (_answerstate == 7)
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

    void AltPath2()
    {
        if (_goodanswer > _badanswer)
        {
            _answerstate++;
            speech.text = "Speaking about the possibility about life and how space makes people feel insignificant, what about about aliens?";
            leftanswer.text = "...They don't exist man.";
            rightanswer.text = "They're all right. A bit mysterious.";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            _answerstate++;
            speech.text = "So like thats it?";
            leftanswer.text = "Yeah. Like IDK what else man.";
            rightanswer.text = "I mean it's space. It's ok.";
            catsprite.sprite = cat[0];
        }
        else if (_goodanswer == _badanswer)
        {
            _answerstate++;
            speech.text = "Oof man IDK how you got here, but how's it going so far?";
            leftanswer.text = "Pretty ok. Code could use some reworking.";
            rightanswer.text = "Is this leading to an anti-climatic ending?";
        }  
    }

    void AltPath3()
    {
        if (_goodanswer > _badanswer)
        {
            _answerstate++;
            speech.text = "No... more like space. I'm from space... is that okay?";
            leftanswer.text = "Like an alien?...oh man..";
            rightanswer.text = "Like an alien? That's totally cool man!";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            _answerstate++;
            speech.text = "Really? Not even if I'm some alien from space?";
            leftanswer.text = "Not really mate.";
            rightanswer.text = "...you're what?";
            catsprite.sprite = cat[0];
        }
        else if (_goodanswer == _badanswer)
        {
            _answerstate++;
            speech.text = "Oof man IDK how you got here, but how's it going so far?";
            leftanswer.text = "Pretty ok. Code could use some reworking.";
            rightanswer.text = "Is this leading to an anti-climatic ending?";
        }   
    }
    
    void ChangeSpeech()
    {
        if (_goodanswer > _badanswer)
        {
            speech.text = "Thanks, I'm glad I met someone as nice as you! Goodbye friend!";
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
    

    
