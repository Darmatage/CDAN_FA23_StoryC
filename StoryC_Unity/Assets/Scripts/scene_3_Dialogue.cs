using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class scene_3_Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //happy
       public GameObject ArtChar1b; //talking
       public GameObject ArtChar1c; //mad
	   
        public GameObject ArtBG1;
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
		 public AudioSource audioSource1;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){ 
		GameHandler.metghost1 = true;
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		
        ArtBG1.SetActive(true);
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
        
		GameHandler.metghost1 = true;
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
                Char1speech.text = "Where the hell are we? Where's the graveyard?”";
                Char2name.text = " ";
                Char2speech.text = " ";
        }
       else if (primeInt == 3){
		   ArtChar1b.SetActive(true);
                Char1name.text = " ";
                Char1speech.text = " ";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "This here is my farm, boy, or what's left of it anyhow. ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = " Whats that smell?";
                Char2name.text = " ";
                Char2speech.text = " ";
        }
       else if (primeInt == 5){
		   ArtChar1b.SetActive(false);
		   ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Brimstone and sulfur, I assume.";
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Thats disgusting! I can barely breathe!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Eh, you get used to it, kiddo.";
        }
        else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Maybe for you. I'm going to have to fill my nose with air freshener when I get home.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Quit yer whining, boy.";
        }
        else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "Why are you here?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Guess god saw fit to stick me among the reminders of my failure";
                 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(How did you die)
                Choice1b.SetActive(true); // function Choice1bFunct(What do you mean)
		}

       // after choice 1a
       else if (primeInt == 20){
		    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
		   ArtChar1c.SetActive(false);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Drank myself to death, coudln't live with what I had done...";
        }
       else if (primeInt == 21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...Do yourself a favor,boy. DOn't go anywhere near dice or cards. Ain't nothihg good bout being a betting man.";
        
				 }
       else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "The only dice I use are D20's for my Dunegeons and Dragons games.";
                Char2name.text = "";
                Char2speech.text = "";
	   }
       else if (primeInt == 23){
		     ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Dragons?Dungeons? I don't even want to know what kind of depravity you get up to...";
				 }
       else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "... All I need is my turnips";
				 }
       else if (primeInt == 25){
                Char1name.text = "YOU";
                Char1speech.text = "...ok....";
                Char2name.text = "";
                Char2speech.text = "";
              // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct(I never liked turnips anyways)
                Choice2b.SetActive(true); // function Choice2bFunct(What about your family? ARe they here with you)
        }

       // after choice 1b
       else if (primeInt == 30){
		    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
		   ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Huh?";
        }
       else if (primeInt == 31){
                Char1name.text = "YOU";
                Char1speech.text = "You mentioned failure. What happened here?";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 32){
		   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "This here land used to be my turnip farm. Me and my family...";
				 }
       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...Have wworked this land for generations. We were proud of our farm, of our tradition, our ethic.";
				 }
       else if (primeInt == 34){
                Char1name.text = "YOU";
                Char1speech.text = "Sounds like you had a good life, and a proud family.";
                Char2name.text = "";
                Char2speech.text = "";
				 }
       else if (primeInt == 35){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "That I did. Untill I saw fit to throw it all in the shitter...";
				 }
       else if (primeInt == 36){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "... Started getting into betting games with the local good fer nothins in town. Thought I had luck of my ancestors on my side...";
				 }
       else if (primeInt == 37){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Didn't take too long till I was there every night, throwing those damn dice...";
        }
       else if (primeInt == 38){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...The more I lost the more I played to get it all back...";
				 }
       else if (primeInt == 39){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Ended up losing it all. Bet the whole damn farm on a toss";
      // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true); // function Choice3aFunct(How could you do that to your family?)
                Choice3b.SetActive(true); // function Choice3bFunct(Don't be so hard on yourself.)
	  }
  // after choice 2a
   
   else if (primeInt == 41){
	   ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(false);
		   ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "NEVER LIKED TURNIPS?!!!";
   }	  
	  else if (primeInt == 42){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah... they have a weird texture and smell, my mom always used to make me eat them.";
                Char2name.text = "";
                Char2speech.text = "";
	  }  
	  else if (primeInt == 43){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "YOU BETTER WATCH YER MOUTH BOY!!";
	  }
	  else if (primeInt == 44){
                Char1name.text = "YOU";
                Char1speech.text = "Woah calm down, its just turnips man, theres no need to be upset.";
                Char2name.text = "";
                Char2speech.text = "";
	  }  
	  else if (primeInt == 45){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Don't tell me to calm down!";
	  }
	  
	 else if (primeInt == 77){
		audioSource1.Play();
		ArtChar1a.SetActive(false);
		  ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(true);
		  StartCoroutine(FadeOut(ArtChar1c, false));
		
		GameHandler.ghost1rampage = true;
		
                Char1name.text = "YOU";
                Char1speech.text = "Oh, crap. Now I have to chase him down???.";
                Char2name.text = "";
                Char2speech.text = "";
	}
	else if (primeInt == 78){
                Char1name.text = "YOU";
                Char1speech.text = "Did I see a farm on the way into town?";
                Char2name.text = "";
                Char2speech.text = "";
	}
		else if (primeInt == 79){
                Char1name.text = "YOU";
                Char1speech.text = "Do I even want to deal with an angry ghost right now?";
                Char2name.text = "";
                Char2speech.text = "";
						//^^ wait for rob to finish this up. But this goes to rampage!		
		nextButton.SetActive(false);
		allowSpace = false;
		NextScene1Button.SetActive(true); // Rampage!	
		NextScene2Button.SetActive(true); // graveyard		
	}
	  
	  
	  
  // after choice 2b

   else if (primeInt == 50){
	    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "If they are, I can't find them. My wife passed about a year before I did.";
   }	  
	  else if (primeInt == 51){
                Char1name.text = "YOU";
                Char1speech.text = "I'm sorry";
                Char2name.text = "";
                Char2speech.text = "";
	  } 
	  else if (primeInt == 52){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Couldn't stand the silence around the house. I had my son...";
	  }	  
	  else if (primeInt == 53){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...But I guess his maw's death made me and him grow distant...";
	  }	  
	  else if (primeInt == 54){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "It's why I started gambling in the first place, had to fill the silence with something...";
	  }	  
	  else if (primeInt == 55){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...Gambled away my bou's college money. Guess he never did forgive me for that. Doubt he even came to the funeral";
	  }	  
	  else if (primeInt == 56){
                Char1name.text = "YOU";
                Char1speech.text = "Gambling can be a hard addiction to beat. I had an uncle that gambled...";
                Char2name.text = "";
                Char2speech.text = "";
	  }	  
	  else if (primeInt == 57){
                Char1name.text = "YOU";
                Char1speech.text = "... Took him years to finally beat it. He did a lot of things he isnt proud of during that time but he learned to live with his mistakes.";
 
                Char2name.text = "";
                Char2speech.text = "";
	  }	  
	  else if (primeInt == 58){
		   ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Do you think I can do the same?";
	  }	  
	  else if (primeInt == 59){
                Char1name.text = "YOU";
                Char1speech.text = "I do, I really do";
                Char2name.text = "";
                Char2speech.text = "";
			//^^^move onto the next ghost after this chat or get the good ending if its the last one	
				nextButton.SetActive(false);
                allowSpace = false;
			if ((GameHandler.metghost2==false)||(GameHandler.metghost3==false)){
				NextScene2Button.SetActive(true); // back to graveyard to meet another ghost
			}	 else {
				NextScene3Button.SetActive(true); // all ghosts pacified. you win!
			}
     }
	 
	 
	 
 // after choice 3a
   else if (primeInt == 70){
	    ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I guess not...my wife died before she could see me destroy our farm...";
   }
   else if (primeInt == 71){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "... but I imagine she's seen the damage I've done from heaven.";
   }   
	else if (primeInt == 72){
                Char1name.text = "YOU";
                Char1speech.text = "So at least you didn't hurt anyone else but yourself.";
                Char2name.text = "";
                Char2speech.text = "";
}	  
	else if (primeInt == 73){
		  ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost farmer ";
                Char2speech.text = " Dont be too hasty with your assumptions, my boy!";
	}
	else if (primeInt == 74){
		ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
		ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost farmer ";
                Char2speech.text = "I still had my dear son with me. What with him still in high school...";
	}	
	
	else if (primeInt == 75){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...he didn’t see much of my gambling but he grew away from me. Guess I wasn’t that great to be around so I dont blame him.";
	}
	else if (primeInt == 76){
		audioSource1.Play();
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Guess I wasn’t that great to be around so I dont blame him.";
	}	

	else if (primeInt == 76){
		ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "BUT I AM STILL RILED UP AND GONNA TELL 'IM SO!.";
	}

	else if (primeInt == 77){
		audioSource1.Play();
		ArtChar1a.SetActive(false);
		  ArtChar1b.SetActive(false);
		  ArtChar1c.SetActive(true);
		  StartCoroutine(FadeOut(ArtChar1c, false));
		
		GameHandler.ghost1rampage = true;
		
                Char1name.text = "YOU";
                Char1speech.text = "Oh, crap. That took a turn.";
                Char2name.text = "";
                Char2speech.text = "";
	}
	else if (primeInt == 78){
                Char1name.text = "YOU";
                Char1speech.text = "Did I see a farm on the way into town?";
                Char2name.text = "";
                Char2speech.text = "";
	}
		else if (primeInt == 79){
                Char1name.text = "YOU";
                Char1speech.text = "Do I even want to deal with an angry ghost right now?";
                Char2name.text = "";
                Char2speech.text = "";
						//^^ wait for rob to finish this up. But this goes to rampage!		
		nextButton.SetActive(false);
		allowSpace = false;
		NextScene1Button.SetActive(true); // Rampage!	
		NextScene2Button.SetActive(true); // graveyard		
	}

	
	
	// after choice 3b
	else if (primeInt == 80){
		ArtChar1a.SetActive(false);
		   ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "What are you talking 'bout, boy?";
   }	  
	else if (primeInt == 81){
                Char1name.text = "YOU";
                Char1speech.text = "You had an illness.";
                Char2name.text = "";
                Char2speech.text = "";
	}	  
				else if (primeInt == 82){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I was healthy 'till the day I drowned my soul in liquor. What the hell you sayin?";
	}	  
					else if (primeInt == 83){
                Char1name.text = "YOU";
                Char1speech.text = "Addiction. We recognize that it is an actual physical illness now. Sometimes people are even born vulnerable to addiction.";
                Char2name.text = "";
                Char2speech.text = "";
	}	  
	else if (primeInt == 84){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "Well now that you mention it, my maw and paw both drank like fishes...";
	}	  
	else if (primeInt == 85){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "...and their maws and paws smoked damn near every hour.";
	}	  
	else if (primeInt == 86){
                Char1name.text = "YOU";
                Char1speech.text = "See, you were already vulnerable before you gambled...";
                Char2name.text = "";
                Char2speech.text = "";
	}	  
	else if (primeInt == 87){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, you did some bad things while you were addicted but addicts are sick and often do terrible things to feed their addiction.";
                Char2name.text = "";
                Char2speech.text = "";
	}	  
	else if (primeInt == 88){
		ArtChar1a.SetActive(true);
		   ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ghost Farmer";
                Char2speech.text = "I guess that makes some kind of sense. Always suspected I been cursed.";
	}	  
	else if (primeInt == 89){
                Char1name.text = "YOU";
                Char1speech.text = "Thats not exactly what I am saying but, sure...";
                Char2name.text = "";
                Char2speech.text = "";
	}	
	else if (primeInt == 90){
		Char1name.text = "";
		Char1speech.text = "";
		Char2name.text = "Ghost Farmer";
		Char2speech.text = "You've given me a lot to think about, boy. Thank you";
	//^^^move on to the next ghost or get good ending if this was the last ghost
		nextButton.SetActive(false);
		allowSpace = false;
		if ((GameHandler.metghost2==false)||(GameHandler.metghost3==false)){
				NextScene2Button.SetActive(true); // back to graveyard to meet another ghost
		}	 else {
				NextScene3Button.SetActive(true); // all ghosts pacified. you win!
		}
	}	  					

						
	//Please do NOT delete this final bracket that ends the Next() function:		
}	


			
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "How did you die?";
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
                Char1speech.text = "What do you mean?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I never liked turnips anyways.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "What about your family? Are they here with you?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
		}
				public void Choice3aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "How could you be so selfish? Did you even think about your family when you were throwing their lives away with your own?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Don't be so hard on yourself, it wasn't entirely your fault.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 79;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){ // rampage!
               SceneManager.LoadScene("scene_6");
        }
        public void SceneChange2(){ // back to graveyard
                SceneManager.LoadScene("scene_2");
        }
		
		public void SceneChange3(){ // You win! All ghosts pacified
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