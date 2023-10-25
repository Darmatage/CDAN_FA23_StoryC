using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene_5_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button; // graveyard Scene_2
        public GameObject NextScene2Button; // end win
		public GameObject NextScene3Button; // rampage at bank Scene_9
        public GameObject nextButton;
       public AudioSource audioSource1;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
				
				if ((GameHandler.metghost1==false)&&(GameHandler.metghost2==false)){
					Char1speech.text = "Wait what the hell? We were just in the graveyard! What's going on?";
				} else {
					Char1speech.text = "Oh so this is what actual Hell looks like. Neat.";
				} 
				
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt ==3){
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Don’t mind the mess, it gets a little crazy here sometimes.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "What?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "I'm a bit of a party animal if you couldn't tell.";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "...Sure...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
		   ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Anyways, I've taken the liberty of looking at your employer's finances and I must say I am quite intrested";
		}
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Wait what how did you???...";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
            Char2speech.text = "It seems that your employer is fudging the books a little, if you know what I mean.";
	   }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "I don't";
                Char2name.text = "";
                Char2speech.text = "";
	  }
       else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Oh no, you're a simpleton. That explains your paystub";
	  }
       else if (primeInt == 12){
                Char1name.text = "YOU";
                Char1speech.text = "Hey!";
                Char2name.text = "";
                Char2speech.text = "";
	  }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Tell me, rube, have you claimed that uniform you're wearing?";
        }
       else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "As a business-related expense in your most recent tax submission?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct():Of course!
                Choice1b.SetActive(true); // function Choice1bFunct():NO....
        }


       // after choice 1a (Of course!)
       else if (primeInt == 20){
		   ArtChar1b.SetActive(true);
           ArtChar1a.SetActive(false);
		   ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Oh really?";
        }
       else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah man, don't sweat it! I totally did that thing you just said.";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Proof of pruchase? Credit card statemen? From 32-C-A_54:CRT?";      
	    }
       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah man! All of that!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Oh really? Well then tell me this: For Section A of Form 32-C-A_54:CRT...";
	  }
       else if (primeInt == 25){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "...did you list your Retirement account as a Roth IRA or a 401k?";
	  }
	    else if (primeInt == 26){
                Char1name.text = "YOU";
                Char1speech.text = "Ummmmm";
                Char2name.text = "";
                Char2speech.text = "";
				//choice 2
                nextButton.SetActive(false);
                allowSpace = false;
				Choice2a.SetActive(true); // function Choice2aFunct():Roth IRA
                Choice2b.SetActive(true); // function Choice2bFunct():401k
	   }

       // after choice 1b
       else if (primeInt == 30){
		   ArtChar1b.SetActive(true);
           ArtChar1a.SetActive(false);
		   ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "I thought as much. One look at those glassy, empty eyes told me everything I needed to know.";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "Now just wait a minute!";
                Char2name.text = "";
                Char2speech.text = "";		 
		 }

       else if (primeInt == 32){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Silnce. I'm working";		
        }
       else if (primeInt == 33){
                Char1name.text = "YOU";
                Char1speech.text = "....";
                Char2name.text = "";
                Char2speech.text = "";				
	 }
       else if (primeInt == 34){
		     ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "There, I’ve added all the relevant information to your tax statement in an addendum.";
				 }
       else if (primeInt == 35){
		    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "You need to make sure you catch these kinds of things next time";
				 }
       else if (primeInt == 36){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks man, jeez I don't even wanna think about what...";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 37){
                Char1name.text = "YOU";
                Char1speech.text = "...would have happened if someone else caught that";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 38){
		    ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Indeed, Now please don't bother me again, I am a very busy man.";	
	   }
	   
	else if (primeInt == 39){
		    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
			//turn off next	
			   nextButton.SetActive(false);
                allowSpace = false;
			if ((GameHandler.ghost1happy == false)||(GameHandler.ghost2happy == false)){		
                Char1speech.text = "On to the next ghost!";
                NextScene1Button.SetActive(true);// go to Scene_2 graveyard
			} else {
				Char1speech.text = "Wow! All three ghosts are happy! Guess I'll call it a a night.";
                NextScene2Button.SetActive(true);// go to win condition
			}		
	   }
	   
	 

// after choice 2a
       else if (primeInt == 40){
		    ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "You mean Roth IRA";
        }
       else if (primeInt == 41){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah whatever";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt == 42){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "And you are quite sure of this?";

        }
       else if (primeInt == 43){
                Char1name.text = "YOU";
                Char1speech.text = "Absolutely. No doubt in my mind whatsoever";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt == 44){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Well then thats certainly intresting to hear";
			
	 }
       else if (primeInt == 45){
                Char1name.text = "YOU";
                Char1speech.text = "Whys that?...";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 46){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "There is no conceivable way you chose that option...";
	
		}
       else if (primeInt == 47){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "...as your employer does not offer anything but a 401k for your retirement account.";
	
		}
       else if (primeInt == 48){
                Char1name.text = "YOU";
                Char1speech.text = "nahhh thats crazy I totally put Ruth down";
                Char2name.text = "";
                Char2speech.text = "";
	    }
       else if (primeInt == 49){
		    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "You are lying to me! You think you can deceive me?";
	    }
       else if (primeInt == 50){
                Char1name.text = "YOU";
                Char1speech.text = "No! Of course not!";
                Char2name.text = "";
				Char2speech.text = "";
	    }
       else if (primeInt == 51){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "I have a quadruple-digit IQ, how dare you insult me by trying to trick my superior mind!";
		}
       else if (primeInt == 52){
		    audioSource1.Play();
		    ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
		  StartCoroutine(FadeOut(ArtChar1c, false));
		  
		  GameHandler.ghost3rampage = true;
                Char1name.text = "YOU";
                Char1speech.text = "Aw jeez this can't be good";
                Char2name.text = "";
                Char2speech.text = "";   
	   }
	   
	   	else if (primeInt == 53){ 
                Char1name.text = "YOU";
                Char1speech.text = "Where would a pissed-off, rampaging accountant ghost go?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		
		else if (primeInt == 54){ 
                Char1name.text = "YOU";
                Char1speech.text = "Huh... I think I saw a bank in town on the way here...";
                Char2name.text = "";
                Char2speech.text = "";
				//access scene change button
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
			if ((GameHandler.metghost1==false)||(GameHandler.metghost2==false)){
				NextScene1Button.SetActive(true);
			}
        }
	   
	   

// after choice 2b
       else if (primeInt == 60){
		    ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Is that so?";
        }
       else if (primeInt == 61){
                Char1name.text = "YOU";
                Char1speech.text = "Yes?";
                Char2name.text = "";
                Char2speech.text = "";
		 }
       else if (primeInt == 62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "You are certain that was your choice?";		
        }
       else if (primeInt == 63){
                Char1name.text = "YOU";
                Char1speech.text = "Cross my heart and hope to die. I swear it.";
                Char2name.text = "";
                Char2speech.text = "";
			
		 }
       else if (primeInt == 64){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "That's very interesting to hear..";
			
		}
       else if (primeInt == 65){
                Char1name.text = "YOU";
                Char1speech.text = "Ummmm why's that?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 66){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Well....";
		 }
       else if (primeInt == 67){
                Char1name.text = "YOU";
                Char1speech.text = "(Oh no, please, not a freakout...)";
                Char2name.text = "";
                Char2speech.text = "";
	    }
       else if (primeInt == 68){
		    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Well it is interesting because that is correct...";
	    }
       else if (primeInt == 69){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "...I was convinced you were attempting to use that smooth lump you call a brain to trick me but it seems I was wrong";
	    }
       else if (primeInt == 70){
                Char1name.text = "YOU";
                Char1speech.text = "Smooth what?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 71){
		    ArtChar1b.SetActive(true);
		   ArtChar1a.SetActive(false);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Its no matter. I misjudged you, I apologize";
		}
       else if (primeInt == 72){
                Char1name.text = "YOU";
                Char1speech.text = "Ummm, don't mention it.";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 73){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Now to conclude our business: your bill.";
		  }
       else if (primeInt == 74){
                Char1name.text = "YOU";
                Char1speech.text = "WHAT?";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 75){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "You will find that I have given you quite a reasonable rate for my services.";
		}
       else if (primeInt == 76){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "As you can see the final total is at the bottom.";
		}
       else if (primeInt == 77){
                Char1name.text = "YOU";
                Char1speech.text = "$8008????";
                Char2name.text = "";
                Char2speech.text = "";
		}
       else if (primeInt == 78){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "Turn it upside down";
				  }
       else if (primeInt == 79){
                Char1name.text = "YOU";
                Char1speech.text = "What? Oh. It says boobs now. Funny";
                Char2name.text = "";
                Char2speech.text = "";
				  }
       else if (primeInt == 80){
		    ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
		    ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Accountant";
                Char2speech.text = "we like to have fun around here";
				 }
       else if (primeInt == 81){
                Char1name.text = "YOU";
                Char1speech.text = "You are literally the only one here";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 99;
		}


		else if (primeInt == 100){
			GameHandler.ghost3happy = true;	
			Char2name.text = "";
			Char2speech.text = "";
			//go to next Scene
			nextButton.SetActive(false);
            allowSpace = false;
			
			Char1name.text = "YOU";
			
			if ((GameHandler.ghost1happy == false)||(GameHandler.ghost2happy == false)){		
                Char1speech.text = "On to the next ghost!";
                NextScene1Button.SetActive(true);// go to Scene_2 graveyard
			} else {
				Char1speech.text = "Wow! All three ghosts are happy! Guess I'll call it a a night.";
                NextScene2Button.SetActive(true);// go to win condition
			}     
	   } 


		//END OF NEXT() function
      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah of course! I mean, who hasnt? Amirite?";
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
                Char1speech.text = "Uhm,well...no...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

//^^^ after you say that you move on to the good ending or the next ghost
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #2 and SceneChanges)
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah I defintely put down a Ruth IRA";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "You know I did a 401k of course!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

	public void SceneChange1(){ //back to graveyard
		SceneManager.LoadScene("Scene_2");
	}
	
	public void SceneChange2(){
		SceneManager.LoadScene("End_Win");
	}
	
	public void SceneChange3(){ // rampage!
		SceneManager.LoadScene("Scene_9");
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
 
