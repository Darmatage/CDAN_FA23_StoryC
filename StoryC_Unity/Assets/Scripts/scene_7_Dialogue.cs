using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_7_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //FURY
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
       else if (primeInt == 3){
		    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh shit I gotta get this under control, or im fucking toast!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 4){
			   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Look at what they've done to this place! Those bumbling fools!";
        }
       else if (primeInt == 5){
                Char1name.text = "Background Character";
                Char1speech.text = "What the fuck is that a freaking ghost?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Background character 2";
                Char2speech.text = "I think it's that guy they told us about from like 40 years ago! ";
	 }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Yo dude! You gotta calm down! You're freaking everyone out!";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 9){
		      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Actor";
                Char2speech.text = "Good! This is what they get for desecrating my stage with their foolishness!";
				 }
       else if (primeInt == 11){
                Char1name.text = "Background character";
                Char1speech.text = "Jesus this guy is like a theasaurus";
                Char2name.text = "";
     	 Char2speech.text = "";
	 }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Tell me about it...";
					 }
       else if (primeInt == 13){
		      ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "Ghost Actor";
                Char1speech.text = "I'll bring this place to the ground!";
                Char2name.text = "";
                Char2speech.text = "";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): "Why do you care so much about this place anyways?"
                Choice1b.SetActive(true); // function Choice1bFunct(): "Who cares if they are bad actors"
        }
		
		
 

       // after choice 1a (Why do you care so much about this place anyways?)
       else if (primeInt == 20){
		      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "How could you even ask me that!?";
        }
	 else if (primeInt == 21){
		 ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I am insulted that your memory is so pitfully small and unreliable";
        }
		else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "Hey man you dont gotta be so mean!";
                Char2name.text = "";
                Char2speech.text = "";
        }
			else if (primeInt == 24){
				   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Surley you remember why I am eternally bound to this stage!";
				// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct(): "Naw man of course I do!"
                Choice2b.SetActive(true); // function Choice2bFunct(): "I have no idea what you are talking about!"
	  }
		
    

       // after choice 1b ("Who cares if they are bad actors")
       else if (primeInt == 30){
                Char1name.text = "Background Character";
                Char1speech.text = "Hey! I'm not that bad!";
                Char2name.text = "";
                Char2speech.text = "";
	   }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Literally shut the fuck up I am trying to save you";
        }
		 else if (primeInt == 32){
			    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "Ghost Actor";
                Char1speech.text = "See! They have no manners or respect for the craft! ";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 34){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Dude it doesen't matter anyways!";
        }
		else if (primeInt == 35){
                Char1name.text = "Ghost Actor";
                Char1speech.text = "Why not? WHy shouldn't my blood boil?!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Because nobody but nerds care about the theater anymore!";
        }
		else if (primeInt == 37){
			   ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "Ghost Actor";
                Char1speech.text = "EXCUSE ME?!!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 38){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Everyone watches Netflix now! Only dorks and rich people go to the theater!";
        }
		else if (primeInt == 39){
                Char1name.text = "Ghost Actor";
                Char1speech.text = "Why you insolent little wrench!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Oh shit...";
        }
		//^^^ go to bad ending after that 
		

	

		
		
		// after choice 2a 
	 else if (primeInt == 50){
		    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Really?";
	   } 
       else if (primeInt == 51){
                Char1name.text = "YOU";
                Char1speech.text = "psssh Yeah man";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
       else if (primeInt == 52){
		      ArtChar1a.SetActive(true);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Then you understand why I am enraged by these fools!";
				
        }
		  else if (primeInt == 53){
                Char1name.text = "YOU";
                Char1speech.text = "As you should be, but think about the damage you are doing!";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
		  else if (primeInt == 54){
			     ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "What?";
				
        }
		  else if (primeInt == 55){
                Char1name.text = "YOU";
                Char1speech.text = "Don't you want to be an inspiration?";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
		  else if (primeInt == 56){ 
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Explain yourself!";
        }
		 else if (primeInt == 57){ 
                Char1name.text = "YOU";
                Char1speech.text = "If you destroy this place,other people won't have a chance to be inspired.. ";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 58){ 
                Char1name.text = "YOU";
                Char1speech.text = "... to follow in your footsteps, to become actors themselevs";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 59){
			    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I guess you may have some kind of point.";
        }
		 else if (primeInt == 60){
			    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "But they have forgotten me! Forgotten my great works of art!";
        }
		 else if (primeInt == 61){
                Char1name.text = "YOU";
                Char1speech.text = "Of course not! Everyone is trying to be as good as you, right guys?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Background character 1";
                Char2speech.text = "Ummm yeah! I try every day to live up to you!";
        }
		 else if (primeInt == 63){
                Char1name.text = "Background character 2";
                Char1speech.text = "Yes! We all do! WHatever it tkaes to get you out of here!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 64){
			    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Oh how wonderfull! My legacy lives on in these budding, inexprienced students of the theater!";
        }
		 else if (primeInt == 65){
                Char1name.text = "Background character 1";
                Char1speech.text = "We arent that bad!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 66){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Dude shut up right fucking now.";
        }
		 else if (primeInt == 67){
                Char1name.text = "Background character 1";
                Char1speech.text = ".......";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 68){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Knowing that I live on through them give me peace. I shall abstain from destruction";
        }
		 else if (primeInt == 69){
                Char1name.text = "YOU";
                Char1speech.text = "oh my god I can't belive that worked";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		//good ending or move on to the next ghost^

		
			// after choice 2b (lie)
       else if (primeInt == 90){
		      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I should have known your feeble mind would forget";
	   } 
	     else if (primeInt == 91){
                Char1name.text = "YOU";
                Char1speech.text = "FORGET WHAT!?";
                Char2name.text = "";
                Char2speech.text = "";
	   } 
	     else if (primeInt == 92){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Be still I will show you!";
	  // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice3aFunct(): "No"
                Choice3b.SetActive(true); // function Choice3bFunct(): "I understand"
	  } 
//have coe above that lets us transition into scene 8 and come back. Choices for reutrning to scnee are added right above



	  
	   // after choice 3a No
       else if (primeInt == 100){
		      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I don't know why I expected you to understand anything! You are hopelessly stupid!";
        }
		
		  else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "Hey!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		  else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "Well maybe you can understand this: Your ignorance is going to be your undoing!";
        }
		
		  else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "Well that can't be good";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		  else if (primeInt == 104){
			     ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Actor";
                Char2speech.text = "I will bring this insult of a theater down around you and these other fools!";
        	// ^^^^ bad ending code entered right below after this text. The scene switch
				
				
		}
		
		

		
		
			  
	   // after choice 3b Yes!
       else if (primeInt == 110){
		      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "You do?";
        }
		   else if (primeInt == 111){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah. Even though it was really lame..";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 112){
                Char1name.text = "YOU";
                Char1speech.text = "... you loved acting and apprently everyone elese loved to see you do it";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I knew you would understand!";
        }
		
		   else if (primeInt == 114){
                Char1name.text = "YOU";
                Char1speech.text = "But you dont gotta go all Rambo on them you know";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 115){
			      ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "who?";
        }
		
		   else if (primeInt == 116){
                Char1name.text = "YOU";
                Char1speech.text = "They are probably just newbies man, they aren't good now...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 117){
                Char1name.text = "YOU";
                Char1speech.text = "...but they could be with some time. I mean, you were just like them at some point.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		   else if (primeInt == 118){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "That is true";   
		}
		
		   else if (primeInt == 119){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah man, so why dont you just chill out and maybe in a few years these guys will be making you proud.";
                Char2name.text = "";
                Char2speech.text = "";   
		}
		
		   else if (primeInt == 120){
			    ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Actor";
                Char2speech.text = "I would love to see the next generation follow in my magnificent footsteps.";   
		}

		//^^ gotta add some text above to make it clear this is gonna lead to the good ending or you gotta move on to the next ghost
		

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "What's your deal? Why do you care so much? It's just a stupid stage";
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
                Char1speech.text = "So what? Who cares if these guys suck?";
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
                Char1speech.text = "Oh yeah that's right! I remember of course!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice2bFunct(){//if we lie 
                Char1name.text = "YOU";
                Char1speech.text = "Dude what are you even talking about? You aren't making sense!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 89;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		
		public void Choice3aFunct(){ //no
                Char1name.text = "YOU";
                Char1speech.text = "Yeah no, all I see was you being an absolute dork then croaking";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice3bFunct(){//I understand 
                Char1name.text = "YOU";
                Char1speech.text = "I kind of get it now";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 109;
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