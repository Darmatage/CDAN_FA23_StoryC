using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_4_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //talking
       public GameObject ArtChar1b; //happy
       public GameObject ArtChar1c; //mad
        public GameObject ArtBG1;
		public GameObject BlackFade;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
		 public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){ 
		GameHandler.metghost2 = true;
 
        DialogueDisplay.SetActive(false);
		ArtBG1.SetActive(true);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		BlackFade.SetActive(false);
		
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
	    Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       Next();
                }
        }
   }

//Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
				
				if ((GameHandler.metghost1==false)&&(GameHandler.metghost3==false)){
					Char1speech.text = "Jesus fuck, where are we? Where did the graveyard go?";
				} else {
					Char1speech.text = "Oh cool...a theater...how original...";
				} 
				
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 3){
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Why yes!You are at the the-at-er!";
        }
		else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "My home! The place where I create and influence!";
        }
       else if (primeInt == 5){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh god just kill me. \nNot this shit.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Now just sit back and relax while I regale you of the story of the Illiad!";
				
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): "No!"
                Choice1b.SetActive(true); // function Choice1bFunct(): "Whatever..."
        }
		
		
 

       // after choice 1a (NO!)
       else if (primeInt == 20){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Where am I? Did I make it out...? Hellooooo???";
                Char2name.text = "";
                Char2speech.text = "";
        }
	 else if (primeInt == 21){
		 ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh goddamnit. I'm back here";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Yes! And now you sit your scrumptious bottom down in that seat...";
        }
		else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...and gaze in astonishment as I conjure Homer’s creation before your eyes!";
        }
       else if (primeInt == 24){
		   StartCoroutine(FadeIn(BlackFade, true));
           BlackFade.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "For fucks sake...";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 39; 	//40=4c
        }


       // after choice 1b (anything you say, if it will get me out of here!)
       else if (primeInt == 30){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Splendid! \nLet us begin!";
	   }
       else if (primeInt == 31){
		   //fade to black
		   StartCoroutine(FadeIn(BlackFade, true));
           BlackFade.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 39; 	//40=4c
        }
		

		//part 4c
		else if (primeInt == 40){
			//fade up from black
		StartCoroutine(FadeOut(BlackFade, true));
        //BlackFade.SetActive(false);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ghost Actor";
            Char2speech.text = "So, now you’ve witnessed my talent on display! What do you think?";
        }
       else if (primeInt == 41){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Phenomenal, right? I can tell by your face I've completely amazed you!";
		// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct(): "Tell the truth"
                Choice2b.SetActive(true); // function Choice2bFunct(): "Lie through your teeth"
		}
		
		
		// after choice 2a (truth)
	 else if (primeInt == 50){
		   ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Didn't you notice me sleeping through the last half of it?";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
       else if (primeInt == 51){
		   ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...What? No, it can't be. \nYou loved it, you know you did!";
	   } 
       else if (primeInt == 52){
                Char1name.text = "YOU";
                Char1speech.text = "I don’t think I have ever seen such bad acting in my life! \nA pumpkin puppetered by mice could have given me a better show!";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
		  else if (primeInt == 53){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "How dare you! Why do you lie like so!";
				
        }
		  else if (primeInt == 54){
                Char1name.text = "YOU";
                Char1speech.text = "Get it through your skull: \nIT. WAS. BAD.";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
		  else if (primeInt == 55){
			  ArtChar1a.SetActive(false);
			  ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I won't hear anymore of your lies! \nI lived my whole life on the stage! Hell...";
				
        }
		  else if (primeInt == 56){ 
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...I even died on it! \nPerforming the very heart-wrenching play I just did for you!";
        }
		 else if (primeInt == 57){ 
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I think the town would be very grateful to see my performance instead";
        }
		 else if (primeInt == 58){ //fade
		  ArtChar1a.SetActive(false);
		  ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(true);
		  StartCoroutine(FadeOut(ArtChar1c, false));
		  
		  GameHandler.ghost2rampage = true;
		  
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 59){ //player goes oh shit
                Char1name.text = "YOU";
                Char1speech.text = "oh shit";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 90;
        }
		
		

		
			// after choice 2b (lie)
       else if (primeInt == 60){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Oh I knew it! Even after all these years stuck in the underworld I still have the gift!";
	   } 
	     else if (primeInt == 61){
                Char1name.text = "YOU";
                Char1speech.text = " I guess?...";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
	     else if (primeInt == 62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "This is just splendid, absolutely splendid!";
	   } 
	     else if (primeInt == 63){
                Char1name.text = "YOU";
                Char1speech.text = "Ok, dude calm down. I said it was great, that's all.";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
	     else if (primeInt == 64){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Oh you must tell me you must!";
	   } 
	     else if (primeInt == 65){
                Char1name.text = "YOU";
                Char1speech.text = "Tell you what?!";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
	     else if (primeInt == 66){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "What your favorite part was! \nWhat did you love about my show?";
	   } 
	     else if (primeInt == 67){
                Char1name.text = "YOU";
                Char1speech.text = "Ummmm...";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice3aFunct(): "It was great..."
                Choice3b.SetActive(true); // function Choice3bFunct(): "I like Homer's show..."
		}




	  
	   // after choice 3a (ending?)
       else if (primeInt == 70){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "What about it? Yes?";
        }
		
		  else if (primeInt == 71){
                Char1name.text = "YOU";
                Char1speech.text = "Ummmmmm...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		  else if (primeInt == 72){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Oh please tell me, please!";
        }
		
		  else if (primeInt == 73){
                Char1name.text = "YOU";
                Char1speech.text = "Huh? I mean, yeah that! Loved it. \nYou really solilo-kweeed that quy! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		  else if (primeInt == 74){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I knew I still have my gift! \nOh thank you for your brave honesty!";
        	
			GameHandler.ghost2happy = true;	
			
			//access scene change button
				nextButton.SetActive(false);
                allowSpace = false;
               // NextScene2Button.SetActive(true); // whew! Who's next?
				
			if ((GameHandler.ghost1happy == false)||(GameHandler.ghost2happy == false)){		
                Char1speech.text = "On to the next ghost!";
                NextScene2Button.SetActive(true);// go to Scene_2 graveyard
			} else {
				Char1speech.text = "Wow! All three ghosts are happy! Guess I'll call it a a night.";
                NextScene3Button.SetActive(true);// go to win condition
			}  	
				
				
				
		}
		
		

		
		
			  
	   // after choice 3b (homer donut!)
       else if (primeInt == 80){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...";
        }
		   else if (primeInt == 81){
                Char1name.text = "YOU";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 82){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "...";
        }
		
		   else if (primeInt == 83){
                Char1name.text = "YOU";
                Char1speech.text = "You said Homer! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 84){
			   ArtChar1a.SetActive(false);
			   ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "HOMER IS THE AUTHOR, YOU IMPUDENT WRETCH!";
        }
		
		   else if (primeInt == 85){
                Char1name.text = "YOU";
                Char1speech.text = "Naw he's the yellow dude. \nHe's not real you idiot. \nIt's just a tv show.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 86){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "YOU DIDNT PAY ATTENTION, DID YOU?!";
        }
		
		   else if (primeInt == 87){
                Char1name.text = "YOU";
                Char1speech.text = "Of course I did, dude!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 88){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "HOW DARE YOU INSULT ME LIKE THIS? I WILL BRING MY TALENTS TO THE TOWN!";   
		}

		 else if (primeInt == 89){ //fade
		   ArtChar1a.SetActive(false);
		  ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(true);
		  StartCoroutine(FadeOut(ArtChar1c, false));
		  
		  GameHandler.ghost2rampage = true;
		  
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 90){ //player goes oh shit
                Char1name.text = "YOU";
                Char1speech.text = "Crap. I should have lied.. why I am so honest?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		else if (primeInt == 91){ 
                Char1name.text = "YOU";
                Char1speech.text = "Where would a disgruntled, rampaging thespian ghost go?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		else if (primeInt == 92){ 
                Char1name.text = "YOU";
                Char1speech.text = "Hmmm... I think I spotted a theater in town on the way here...";
                Char2name.text = "";
                Char2speech.text = "";
				//access scene change button
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
			if ((GameHandler.metghost1==false)||(GameHandler.metghost3==false)){
				NextScene2Button.SetActive(true);
			}
        }
		

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I cannot listen to this.Where is the exit?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure. Whatever it takes me to get out of this dump";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
        public void Choice2aFunct(){ //if we say truth
                Char1name.text = "YOU";
                Char1speech.text = "Dude what are you talking about?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice2bFunct(){//if we lie 
                Char1name.text = "YOU";
                Char1speech.text = "Yeah dude….it was……great. Loved it.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice3aFunct(){ //if we say truth
                Char1name.text = "YOU";
                Char1speech.text = "The ending?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice3bFunct(){//if we lie 
                Char1name.text = "YOU";
                Char1speech.text = "Umm.. yeah, so, I really liked that part where Homer eats the donut!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 79;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		

		
        public void SceneChange1(){//actor ghost rampage scene
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){//succeed in calming the ghost, go to graveyard
                SceneManager.LoadScene("Scene_2");
        }
		
		public void SceneChange3(){//all ghosts calm, End Win
                SceneManager.LoadScene("End_Win");
        }
		
		
		IEnumerator FadeIn(GameObject fadeImage, bool isBlack){
			int col = 1;
			if (isBlack){col=0;} else {col=1;} 
			
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage, bool isBlack){
			int col = 1;
			if (isBlack){col=0;} else {col=1;} 
				
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(col, col, col, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }
		
		
		
}