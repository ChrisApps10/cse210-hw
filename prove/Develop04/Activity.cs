using System;

class Activity
{
    //attributes
   protected int _timeDuration;
   protected string _congratsMessage = "Well done!";

   //constructors
   public Activity()
   {
      _timeDuration = 10;
   }
   public Activity(int _timeDuration)
   {
      _timeDuration = _timeDuration;
   }

    // methods
    public void runActivity(int choice)
    {
        if (choice == 1)
        {
            Breathing breathingActivity = new Breathing(_timeDuration);
            breathingActivity.runBreathingActivity(_timeDuration);

        } 
        else if (choice == 2)
        {
            Reflecting reflectingActivity = new Reflecting (_timeDuration);
            reflectingActivity.runReflectingActivity(_timeDuration);
        }
        else if (choice == 3)
        {
            Listing listingActivity = new Listing(_timeDuration);
            listingActivity.runListingActivity(_timeDuration);
        }
    }
   public void setTimeDuration()
   {
    Console.WriteLine("How long, in seconds, would you like for your session? ");
    string response = Console.ReadLine();
    int timeDuration = int.Parse(response);
    _timeDuration = timeDuration * 100;
   }

   public int getTimeDuration()
   {
    return _timeDuration;
   }
}

  